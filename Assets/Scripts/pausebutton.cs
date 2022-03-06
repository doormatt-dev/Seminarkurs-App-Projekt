using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class pausebutton : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    
    FlightControls flightControls;

    void Awake()
    {
    flightControls = new FlightControls();
        flightControls.Flight.Pause.performed += ctx => togglePauseMenu();
    }
    
    void OnEnable()
    {
        //when it beomes active, start listening to inputs
        flightControls.Flight.Enable();
    }
    
    void OnDisable()
    {
        //turn off controls when disabled just in case i guess
        flightControls.Flight.Disable();
    }
    
    // Start is called before the first frame update
    void togglePauseMenu()
    {
        if(pauseMenu == null)
        {
            Debug.LogWarning("no pause menu assigned!");
            return;
        }
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }
}
