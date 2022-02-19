using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class SpaceshipMovment : MonoBehaviour

{
    //(Private) variables
    float movmentStrength, yawStrength,pitchStrength,rollStrength,zoomedness,currentYaw,currentMovstr,currentPitch,currentRoll,yawVelocity,movstrVelocity,rollVelocity,pitchVelocity,smoothtime = 3.0f,maxSmoothSpeed = 5.0f;

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
        //flightControls.Flight.Shoot.cancelled += ctx => ;
    }
    // Start is called before the first frame update
    void Start()
    {
        rigBody = GetComponent<Rigidbody>();
        SetShip(currentShipID);
    }
    void OnEnable()
    {
        flightControls.Flight.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        //cameraRotation.SetLookRotation(new Vector3(Rotation_freedom.x * pitchStrength, Rotation_freedom.y * yawStrength, Rotation_freedom.z * rollStrength));
        zoomedness = Mathf.Clamp(rigBody.velocity.magnitude / 20.0f - 1.0f, 0.0f, 1.0f);
        Vector3 newpos = transform.position + (transform.rotation * Vector3.Lerp(Close_pos,Far_pos,zoomedness));
        Quaternion newrot = transform.rotation * Quaternion.Euler(Vector3.Lerp(Close_rot,Far_rot,zoomedness));// + cameraRotation.eulerAngles.normalized);
        MainCam.transform.SetPositionAndRotation(newpos,newrot);
        Camera.main.fieldOfView = Close_fov + (Far_fov - Close_fov) * zoomedness;

        if(currentAnimator != null)
        {
            currentMovstr = Mathf.SmoothDamp(currentMovstr,movmentStrength,ref movstrVelocity,smoothtime/*,maxSmoothSpeed*/);
            currentYaw = Mathf.SmoothDamp(currentYaw,yawStrength,ref yawVelocity,smoothtime/*,maxSmoothSpeed'*/);
            currentPitch = Mathf.SmoothDamp(currentPitch,pitchStrength,ref pitchVelocity,smoothtime/*,maxSmoothSpeed*/);
            currentRoll = Mathf.SmoothDamp(currentRoll,rollStrength,ref rollVelocity,smoothtime/*,maxSmoothSpeed*/);

            currentAnimator.SetFloat("booster",Mathf.Clamp(currentMovstr,0,1));
            currentAnimator.SetFloat("turnStrength",currentYaw);
            currentAnimator.SetFloat("pitchStrength",-currentPitch);
            currentAnimator.SetFloat("rollStrength",-currentRoll);
        }

    }

    void FixedUpdate()
    {
        deltaMove = new Vector3(0f,0f,movmentStrength) * Speed;

        deltaRotation = new Vector3(pitchStrength,yawStrength,rollStrength) * RotationSpeed;

        rigBody.AddRelativeForce(deltaMove,ForceMode.Force);
        rigBody.AddRelativeTorque(deltaRotation,ForceMode.Force);
    }

    void OnDisable()
    {
        flightControls.Flight.Disable();
    }

    void SpawnAnObstacle()
    {
        GameObject newComet = CometPooler.CometPool.GetComet();
        if(newComet != null)
        {
            newComet.transform.SetPositionAndRotation(transform.position + transform.forward * CometPooler.CometPool.spawndistance, transform.rotation);
            newComet.SetActive(true);
        }
    }

    public void SetShip(int newShipID)
    {
        /*if(newShipID == currentShipID){
            Debug.Log("Ship " + currentShipID + " is already selected!");
            return;
        }*/
        if(newShipID >= Spaceships.Length || newShipID < 0)//basic error handling
        {
            Debug.LogError("ID of new ship outside of list");
            return;
        }

        Destroy(childShip);//remove the old one (even if there wasn't one but eh)
        
        childShip = Instantiate(Spaceships[newShipID].shipPrefab, transform.position, Quaternion.Euler(transform.forward),self);
        childShip.transform.localRotation = new Quaternion(0,0,0,0);//you want it to definitely be pointing forwards
        //childShip.transform.SetParent(self.transform);
        currentAnimator = childShip.GetComponent<Animator>();//grab the animatior once so we don't have to get component all the time
        childShip.SetActive(true);


        rigBody.mass = Spaceships[newShipID].mass;
        Speed = Spaceships[newShipID].acceleration;
        rigBody.drag = Spaceships[newShipID].drag;
        RotationSpeed = Spaceships[newShipID].angularAcceleration;
        rigBody.angularDrag = Spaceships[newShipID].angularDrag;
        smoothtime = Spaceships[newShipID].smoothtime;

        currentShipID = newShipID;//save that we are now using this ship

        Debug.Log("Ship set to '" + Spaceships[newShipID].shipName + "' (" + newShipID + ") and Paramerers loaded!");
    }
    
    public void cycleShip(){//just goes through the list, really simple
        int newShipID = currentShipID + 1;
        if(newShipID >= Spaceships.Length)
        {
            newShipID = 0;
        }
        Debug.Log("Switching to next ship (shipID " + newShipID + " )");
        SetShip(newShipID);
    }
}
