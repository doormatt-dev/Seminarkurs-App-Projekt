using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void loadScene(int num)
    {
        Debug.Log("loading scene " + num);
        SceneManager.LoadScene(num, LoadSceneMode.Single);
    }
  
    public void quitApp()
    {
        UnityEngine.Application.Quit();
    }
}
