using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    public float volume = 0.5f;
    
    public void setVolume(float volume){
        this.volume = volume;
    }

}
