using UnityEngine;
using System;

[Serializable]
public class SpaceshipDataobject
{
    //these are just the parameters for the ships how they appear in the list, these are required to set up the ship completely
    public string shipName;
    public Texture menuImage;
    public GameObject shipPrefab;
    public float mass;
    public float acceleration;
    public float drag;
    public float angularAcceleration;
    public float angularDrag;
    public float smoothtime;
    public float maxHP;
    public bool animate;
}
