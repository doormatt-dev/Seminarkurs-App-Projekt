using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UserPrefMgr : MonoBehaviour
{
    public static UserPrefMgr settings;

    public int graphicsLevel;
    public int saveSlotNr;
    public bool showOnScreenControls;

     GameObject OSC;
     string currentSceneName;

    void Awake()
    {
        //as soon as this Object exists check if there is already one and then destroy self or become the only one
        if(settings == null)
        {
            DontDestroyOnLoad(gameObject);
            settings = this;
            Debug.Log("New UserPrefMgr set");
        }else if(settings != this){
            Debug.Log("UserPrefMgr duplicate destroyed");
            Destroy(gameObject);
        }
        //stuff for setting screen rotation in different scenes
        currentSceneName = SceneManager.GetActiveScene().name;
        if(currentSceneName == "InGame")
        {//when playing only allow landscape orientation(s)
            Screen.orientation = ScreenOrientation.Landscape;
            Debug.Log("Rotation set to only Landscape");
        }else if(currentSceneName == "Startmenu"){//menus can have any rotation (except upside down)
            Screen.orientation = ScreenOrientation.AutoRotation;
            Screen.autorotateToPortraitUpsideDown = false;
            Debug.Log("Rotation set to Autorotate");
        }else{//scene doesn't have any settings, default to portrait and lock
            Screen.orientation = ScreenOrientation.Portrait;
            Debug.LogWarning("Unsupported Scene, what rotation settings should it have?");
        }

        //Obtain User Prefs
        graphicsLevel = Mathf.Clamp(PlayerPrefs.GetInt("graphicsLevel", 2), 0, 3);//int for graphics preset 0-3
        saveSlotNr = PlayerPrefs.GetInt("saveSlot",0);//int for save slot #, not currently supported but eh
        showOnScreenControls = (PlayerPrefs.GetInt("showOSC",1) != 0);//are on-screen-joysticks on or off?

        UpdateSettings();//apply these settings
    }

    void UpdateSettings()
    {
        //Set quality level accordingly
        if(UnityEngine.QualitySettings.GetQualityLevel() != graphicsLevel)
        {
            UnityEngine.QualitySettings.SetQualityLevel(graphicsLevel);
            Debug.Log("Graphics quality set to "+ graphicsLevel);
        }else{
            Debug.Log("Graphics quality already set to " + graphicsLevel);
        }

        Debug.Log("Save slot is " + saveSlotNr);//this is everything the save slot # does

        //Show or hide the on screen controls if there are any
        OSC = GameObject.Find("/UI Canvas/OSC");//see if here even are any controls, there are none in the main menu
        if(OSC != null)
        {
            OSC.SetActive(showOnScreenControls);
            Debug.Log("onscreen controls set to " + showOnScreenControls);
        }else{
            Debug.Log("No osc present");
        }
        SaveSettings();//this is kinda useless unless some settings were somehow changed

    }

    void SaveSettings()//take the loaded variables and put their values in the save, simple
    {

        PlayerPrefs.SetInt("graphicsLevel", graphicsLevel);
        PlayerPrefs.SetInt("saveSlot", saveSlotNr);
        if(showOnScreenControls)
        {
            PlayerPrefs.SetInt("showOSC", 1);
        }else{
            PlayerPrefs.SetInt("showOSC", 0);
        }
        

    }
    
    void OnGUI()
    {
        //this is just a crude FPS counter for debugging
        GUI.Box(new Rect(Screen.width * 0.9f,Screen.height * 0.05f, 80.0f, 30.0f), (1.0f/ Time.deltaTime).ToString());
    }
    
}
