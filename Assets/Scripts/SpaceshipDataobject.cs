using UnityEngine;
using System;

[Serializable]
public class SpaceshipDataobject
{
    public string shipName;
    public Texture menuImage;
    public GameObject shipPrefab;
    public float mass;
    public float acceleration;
    public float drag;
    public float angularAcceleration;
    public float angularDrag;
    public float maxHP;
    public bool animate;
}
