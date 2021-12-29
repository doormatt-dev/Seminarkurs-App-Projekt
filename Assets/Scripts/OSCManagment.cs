using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSCManagment : MonoBehaviour
{
    public static OSCManagment primaryOSC;
    void Awake()
    {
        if(primaryOSC != null)
        {
            Debug.LogWarning("additional OSC removed, why were ther multiple OSCs?");
            Destroy(gameObject);
        }
        primaryOSC = this;
        Debug.Log("Primary OSC assigned");

        gameObject.SetActive(UserPrefMgr.settings.showOnScreenControls);
    }
}
