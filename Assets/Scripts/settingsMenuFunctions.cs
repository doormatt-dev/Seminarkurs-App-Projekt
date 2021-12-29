using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsMenuFunctions : MonoBehaviour
{

    public void OSCset(bool stateToSet)
    {
        UserPrefMgr.settings.showOnScreenControls = stateToSet;
    }

    public void OSCtoggle()
    {
        UserPrefMgr.settings.showOnScreenControls = !UserPrefMgr.settings.showOnScreenControls;
    }

    public void OnMenuExit()
    {
        UserPrefMgr.settings.UpdateSettings();
    }
}
