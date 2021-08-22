using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comet : MonoBehaviour
{
    GameObject RefrenceObject = CometPooler.CometPool.RefrenceObject();
     private float distance;
    

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Magnitude(transform.position - RefrenceObject.transform.position);
        if(distance >= CometPooler.CometPool.despawnDistance())
        {
            this.gameObject.SetActive(false);
        }
    }
}
