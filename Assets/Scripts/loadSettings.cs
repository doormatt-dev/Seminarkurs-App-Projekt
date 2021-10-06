using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSettings : MonoBehaviour
{
    public void loadSettingsScene()
    {
        Debug.Log("loading scene 2");
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    
    }

    public void quitApp()
    {
        UnityEngine.Application.Quit();
    }
}
