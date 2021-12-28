using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadHomeMenu : MonoBehaviour
{
    public void loadHomeMenuScene()
    {
        Debug.Log("loading scene 0");
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
// i don't know why this has a separate script tbh