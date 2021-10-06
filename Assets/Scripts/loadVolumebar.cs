using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadVolumebar : MonoBehaviour
{  
    public void loadVolumebarScene()
    {
        Debug.Log("loading scene 3");
        SceneManager.LoadScene(3, LoadSceneMode.Single);
        
    }
  
    public void quitApp()
    {
        UnityEngine.Application.Quit();
    }
}
