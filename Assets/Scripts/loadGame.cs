using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour
{
    public void loadGameScene()
    {
        Debug.Log("loading scene 1");
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}