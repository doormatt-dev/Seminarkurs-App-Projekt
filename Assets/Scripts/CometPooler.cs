using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometPooler : MonoBehaviour
{
    [SerializeField] GameObject Comets;
    [SerializeField] int Pool_size;
    [SerializeField] float despawndistance;
    [SerializeField] float spawndistance;
    [SerializeField] GameObject Player;

    public static CometPooler CometPool;
    public List<GameObject> cometPool;

    void Awake()
    {
        CometPool = this;
    }
    void Start()
    {
        cometPool = new List<GameObject>();
        GameObject tmp;
        for(int i = 0; i < Pool_size; i++)
        {
            tmp = Instantiate(Comets);
            tmp.transform.SetParent(transform);
            tmp.SetActive(false);
            cometPool.Add(tmp);
        }
    }


    public GameObject GetComet(Vector3 Position, Quaternion Rotation)
    {
        for(int i = 0; i < Pool_size; i++)
        {
            if(!cometPool[i].activeInHierarchy)
            {
                //cometPool[i].transform.SetPositionAndRotation(Position,Rotation);
                return cometPool[i];
            }
        }
        return null;
    }
    public GameObject RefrenceObject()
    {
        return Player;
    }

    public float despawnDistance()
    {
        return despawndistance;
    }
    public float spawnDistance()
    {
        return spawndistance;
    }
}
