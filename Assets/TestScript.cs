using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Slider slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(OnValueChange);
    }

    public void OnValueChange(float value){
        GameObject.FindGameObjectsWithTag("UserPref")[0].GetComponent<PlayerSettings>().setVolume(value);
    }
}
