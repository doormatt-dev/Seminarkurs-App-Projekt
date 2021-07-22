using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SpaceshipMovment : MonoBehaviour

{
    //Private variables
    float movmentStrength;
    float yawStrength;
    float pitchStrength;
    float rollStrength;
    Vector3 deltaMove;
    Vector3 deltaRotation;
    Rigidbody rigBody;

    //Input fields
    [SerializeField] float Speed;
    [SerializeField] float RotationSpeed;

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
    /*void Update()
    {
        deltaMove = new Vector3(0f,0f,movmentStrength) * Time.deltaTime * Speed;

        deltaRotation = new Vector3(pitchStrength,yawStrength,rollStrength) * Time.deltaTime * RotationSpeed;

        //transform.Translate(deltaMove,Space.Self);
        //transform.Rotate(deltaRotation,Space.Self);
    }*/

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
}
