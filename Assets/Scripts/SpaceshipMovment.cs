using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class SpaceshipMovment : MonoBehaviour

{
    //(Private) variables
    float movmentStrength;
    float yawStrength;
    float pitchStrength;
    float rollStrength;
    float zoomedness;
    int currentShipID;
    Vector3 deltaMove;
    Vector3 deltaRotation;
    Quaternion cameraRotation;
    Rigidbody rigBody;
    GameObject childShip;

    //Input fields
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

    void SetShip(int newShipID)
    {
        if(newShipID == currentShipID){
            Debug.Log("Ship " + currentShipID + " is already selected!");
            return;
        }

        Destroy(childShip);
        childShip = Spaceships[newShipID].shipPrefab;
        Instantiate(childShip, Vector3.zero, Quaternion.Euler(Vector3.forward));
        childShip.transform.SetParent(this.transform);
        childShip.SetActive(true);


        rigBody.mass = Spaceships[newShipID].mass;
        Speed = Spaceships[newShipID].acceleration;
        rigBody.drag = Spaceships[newShipID].drag;
        RotationSpeed = Spaceships[newShipID].angularAcceleration;
        rigBody.angularDrag = Spaceships[newShipID].angularDrag;

        currentShipID = newShipID;

        Debug.Log("Ship set to " + newShipID + "and Paramerers loaded!");
    }
}
