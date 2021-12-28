using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class SpaceshipMovment : MonoBehaviour

{
    //(Private) variables
    float movmentStrength, yawStrength,pitchStrength,rollStrength,zoomedness,currentYaw,currentMovstr,currentPitch,currentRoll,yawVelocity,movstrVelocity,rollVelocity,pitchVelocity,smoothtime = 3.0f;

    int currentShipID;
    Vector3 deltaMove;
    Vector3 deltaRotation;
    Quaternion cameraRotation;
    Rigidbody rigBody;
    GameObject childShip;
    Animator currentAnimator;

    //Input fields
    [SerializeField] Transform self;
    [SerializeField] float Speed;
    [SerializeField] float RotationSpeed;
    [SerializeField] GameObject MainCam;
    [SerializeField] Vector3 Close_pos;
    [SerializeField] Vector3 Close_rot;
    [SerializeField] float Close_fov;
    [SerializeField] Vector3 Far_pos;
    [SerializeField] Vector3 Far_rot;
    [SerializeField] float Far_fov;
    [SerializeField] Vector3 Rotation_freedom;
    [SerializeField] SpaceshipDataobject[] Spaceships;

    //Input System
    FlightControls flightControls;

    void Awake()
    {
        //activate bindings for flying
        flightControls = new FlightControls();
        //forwards/backwards
        flightControls.Flight.Throttle.performed += ctx => movmentStrength = ctx.ReadValue<float>();
        flightControls.Flight.Throttle.canceled += ctx => movmentStrength = 0f;
        //yaw
        flightControls.Flight.Yaw.performed += ctx => yawStrength = ctx.ReadValue<float>();
        flightControls.Flight.Yaw.canceled += ctx => yawStrength = 0f;
        //pitch
        flightControls.Flight.Pitch.performed += ctx => pitchStrength = ctx.ReadValue<float>();
        flightControls.Flight.Pitch.canceled += ctx => pitchStrength = 0f;
        //roll
        flightControls.Flight.Roll.performed += ctx => rollStrength = ctx.ReadValue<float>();
        flightControls.Flight.Roll.canceled += ctx => rollStrength = 0f;
        //spawn an obstacle
        flightControls.Flight.Shoot.performed += ctx => SpawnAnObstacle();
        flightControls.Flight.Swapship.performed += ctx => cycleShip();
        //flightControls.Flight.Shoot.cancelled += ctx => ;
    }
    // Start is called before the first frame update
    void Start()
    {
        //gets a refrence to it's onw rigid body component, GetComponent shoud be fine as this only happens on load ideally
        rigBody = GetComponent<Rigidbody>();
        SetShip(currentShipID);
    }
    void OnEnable()
    {
        //when it beomes active, start listening to inputs
        flightControls.Flight.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //cameraRotation.SetLookRotation(new Vector3(Rotation_freedom.x * pitchStrength, Rotation_freedom.y * yawStrength, Rotation_freedom.z * rollStrength));
        //calculate how zoomed out it should be based on speed
        zoomedness = Mathf.Clamp(rigBody.velocity.magnitude / 20.0f - 1.0f, 0.0f, 1.0f);
        //calculate camera params with linear interpolation from values in the serialised fields
        Vector3 newpos = transform.position + (transform.rotation * Vector3.Lerp(Close_pos,Far_pos,zoomedness));
        Quaternion newrot = transform.rotation * Quaternion.Euler(Vector3.Lerp(Close_rot,Far_rot,zoomedness));// + cameraRotation.eulerAngles.normalized);
        MainCam.transform.SetPositionAndRotation(newpos,newrot);
        Camera.main.fieldOfView = Close_fov + (Far_fov - Close_fov) * zoomedness;

        if(currentAnimator != null)//if the ship currently active has an animator
        {
            //setting animator parameters for flying animations
            //calculate values first
            currentMovstr = Mathf.SmoothDamp(currentMovstr,movmentStrength,ref movstrVelocity,smoothtime/*,maxSmoothSpeed*/);
            currentYaw = Mathf.SmoothDamp(currentYaw,yawStrength,ref yawVelocity,smoothtime/*,maxSmoothSpeed'*/);
            currentPitch = Mathf.SmoothDamp(currentPitch,pitchStrength,ref pitchVelocity,smoothtime/*,maxSmoothSpeed*/);
            currentRoll = Mathf.SmoothDamp(currentRoll,rollStrength,ref rollVelocity,smoothtime/*,maxSmoothSpeed*/);
            //and set the parameters
            currentAnimator.SetFloat("booster",Mathf.Clamp(currentMovstr,0,1));//some should be clamped
            currentAnimator.SetFloat("turnStrength",currentYaw);
            currentAnimator.SetFloat("pitchStrength",-currentPitch);//some need inversion
            currentAnimator.SetFloat("rollStrength",-currentRoll);
        }

    }

    void FixedUpdate()
    {
        deltaMove = new Vector3(0f,0f,movmentStrength) * Speed;//thottle force vector

        deltaRotation = new Vector3(pitchStrength,yawStrength,rollStrength) * RotationSpeed;//angular force for turning and spinning

        //apply them to the rigid body, forces are used because direct movments cause issues with physics
        rigBody.AddRelativeForce(deltaMove,ForceMode.Force);
        rigBody.AddRelativeTorque(deltaRotation,ForceMode.Force);
    }

    void OnDisable()
    {
        //turn off controls when disabled just in case i guess
        flightControls.Flight.Disable();
    }

    void SpawnAnObstacle()//this spawns in random environment stuffs
    {
        GameObject newComet = CometPooler.CometPool.GetComet();
        if(newComet != null)
        {
            newComet.transform.SetPositionAndRotation(transform.position + transform.forward * CometPooler.CometPool.spawndistance, transform.rotation);
            newComet.SetActive(true);
        }
    }

    public void SetShip(int newShipID)
    {//swaps out the ship to a specific one
        /*if(newShipID == currentShipID){
            Debug.Log("Ship " + currentShipID + " is already selected!");
            return;
        }*/

        Destroy(childShip);//remove the old one
        
        childShip = Instantiate(Spaceships[newShipID].shipPrefab, transform.position, Quaternion.Euler(transform.forward),self);//get a new one from presets
        childShip.transform.localRotation = new Quaternion(0,0,0,0);//make sure it's pointing forward
        //childShip.transform.SetParent(self.transform);
        currentAnimator = childShip.GetComponent<Animator>();//get the new animator
        childShip.SetActive(true);//show the ship to the user

        //assign physics parameters and characteristics, basically the handling of the ship
        rigBody.mass = Spaceships[newShipID].mass;
        Speed = Spaceships[newShipID].acceleration;
        rigBody.drag = Spaceships[newShipID].drag;
        RotationSpeed = Spaceships[newShipID].angularAcceleration;
        rigBody.angularDrag = Spaceships[newShipID].angularDrag;
        smoothtime = Spaceships[newShipID].smoothtime;

        currentShipID = newShipID;//set the current ID

        Debug.Log("Ship set to '" + Spaceships[newShipID].shipName + "' (" + newShipID + ") and Paramerers loaded!");
    }
    
    public void cycleShip(){//takes the setShip function to cycle through all available ships
        int newShipID = currentShipID + 1;//add 1, yes very simple, just take the next one easy
        if(newShipID >= Spaceships.Length)//check if it's a value in the list
        {
            newShipID = 0;//if not then go back to the start
        }
        Debug.Log("Switching to next ship (shipID " + newShipID + " )");
        SetShip(newShipID);
    }
}
