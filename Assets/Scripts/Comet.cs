using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comet : MonoBehaviour
{
    float scalefactor;
    GameObject RefrenceObject;// = CometPooler.CometPool.RefrenceObject();//refrence object should be something attached to the player
    private float distance;

    void Awake()
    {
        RefrenceObject = CometPooler.CometPool.RefrenceObject();
        if(RefrenceObject == null){Debug.LogError("No refrence object for comet found!");}
    }
    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Magnitude(transform.position - RefrenceObject.transform.position);//ge distance to refrence
        distanceScale(distance,175.0f,150.0f,new Vector3(0.0f,0.0f,0.0f),new Vector3(10.0f,10.0f,10.0f));
        if(distance >= CometPooler.CometPool.despawnDistance())//if it's far enough away
        {
            this.gameObject.SetActive(false);//simply deactivate so it can be reused by the object pool
        }
    }

    void distanceScale(float distanceToObject ,float distanceMinscale,float distanceFullscale, Vector3 Minscale, Vector3 Fullscale)
    {//calculates how large the comet should be based on params
        scalefactor = Mathf.Clamp((distance - distanceFullscale)/(distanceMinscale - distanceFullscale),0,1);
        transform.localScale = Vector3.Lerp(Fullscale,Minscale,scalefactor);//set own scale
    }
}
