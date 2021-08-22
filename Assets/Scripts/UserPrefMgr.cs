using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserPrefMgr : MonoBehaviour
{
    public static UserPrefMgr settings;

    public int graphicsLevel;
    public int saveSlotNr;
    public bool showOnScreenControls;

    private GameObject OSC;

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

        //Obtain User Prefs
        graphicsLevel = Mathf.Clamp(PlayerPrefs.GetInt("graphicsLevel", 2), 0, 3);
        saveSlotNr = PlayerPrefs.GetInt("saveSlot",0);
        showOnScreenControls = (PlayerPrefs.GetInt("showOSC",1) != 0);

        //Set quality level accordingly
        if(UnityEngine.QualitySettings.GetQualityLevel() != graphicsLevel)
        {
            UnityEngine.QualitySettings.SetQualityLevel(graphicsLevel);
            Debug.Log("Graphics quality set to "+ graphicsLevel);
        }else{
            Debug.Log("Graphics quality already set to " + graphicsLevel);
        }

        Debug.Log("Save slot is " + saveSlotNr);

        //Show or hide the on screen controls if there are any
        OSC = GameObject.Find("/UI Canvas/Onscreen Controls");
        if(OSC != null)
        {
            OSC.SetActive(showOnScreenControls);
            Debug.Log("onscreen controls set to " + showOnScreenControls);
        }else{
            Debug.Log("No osc present");
        }
    }
    
}
