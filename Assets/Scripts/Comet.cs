using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comet : MonoBehaviour
{
    float scalefactor;
    GameObject RefrenceObject = CometPooler.CometPool.RefrenceObject();
     private float distance;
    

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Magnitude(transform.position - RefrenceObject.transform.position);
        distanceScale(distance,150.0f,125.0f,new Vector3(0.0f,0.0f,0.0f),new Vector3(10.0f,10.0f,10.0f));
        if(distance >= CometPooler.CometPool.despawnDistance())
        {
            this.gameObject.SetActive(false);
        }
    }

    void distanceScale(float distanceToObject ,float distanceMinscale,float distanceFullscale, Vector3 Minscale, Vector3 Fullscale)
    {
        scalefactor = Mathf.Clamp((distance - distanceFullscale)/(distanceMinscale - distanceFullscale),0,1);
        transform.localScale = Vector3.Lerp(Fullscale,Minscale,scalefactor);
    }
}
