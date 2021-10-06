using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateVolume : MonoBehaviour
{
    public float volumeMultiplier = 0.6f;
    void FixedUpdate() {
        GetComponent<AudioSource>().volume = GameObject.FindGameObjectsWithTag("UserPref")[0].GetComponent<PlayerSettings>().volume * volumeMultiplier;
    }
}
