using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometPooler : MonoBehaviour
{
    [SerializeField] GameObject Comets;
    [SerializeField] int Pool_size;
    [SerializeField] float despawndistance;
    [SerializeField] public float spawndistance;
    [SerializeField] GameObject Player;
    [SerializeField] bool spawnAutomatically;
    [SerializeField] float minTimeBetweenSpawns;
    [SerializeField] float minDistanceMovedBetweenSpawns;
    [SerializeField] float minDistanceBetweenCometSpawns;

    public static CometPooler CometPool;
    public List<GameObject> cometPool;
    Vector3 previousSpawnPos,previousShipPos;
    double timeOfLastSpawn;
    bool farenoughMoved,longEnoughDelay;

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

    void Update()
    {
        farenoughMoved = Vector3.Distance(Player.transform.position,previousShipPos) > minDistanceMovedBetweenSpawns;//did you move far enough
        longEnoughDelay = Time.unscaledTime - timeOfLastSpawn >= minTimeBetweenSpawns;// has the min amount of time passed

        if(spawnAutomatically && longEnoughDelay && farenoughMoved)//determines if it should spawn another comet
        {//only do this if you're supposed to and enough time has passed spawn comets else don't

            GameObject objectToSpawn = GetComet();//fetches a new comet object from the children
            if(objectToSpawn != null)//checks if there was one available
            {
                //Vector3 spawnpos = Player.transform.position + (Player.GetComponent<Rigidbody>().velocity.normalized * spawndistance);
                Vector3 spawnpos = previousSpawnPos;
                while(Vector3.Distance(previousSpawnPos,spawnpos) < minDistanceBetweenCometSpawns)//make sure the comets aren`t piling up
                {
                    spawnpos = Player.transform.rotation * (new Vector3(Random.Range(-0.5f,0.5f),Random.Range(-0.5f,0.5f),1).normalized * spawndistance) + Player.transform.position;//position of new comet infront of the ship's direction of travel
                }

                objectToSpawn.transform.SetPositionAndRotation(spawnpos,Random.rotation);//put it there and roatate to whatever orientation to not make it boring
                objectToSpawn.SetActive(true);//set it active
                //variables about previous spawn so comets don't spawn too close or inside each other
                previousSpawnPos = spawnpos;
                previousShipPos = Player.transform.position;
                timeOfLastSpawn = Time.unscaledTime;
            }
            
        }
    }


    public GameObject GetComet()//this function grabs an inactive comet object from the pool and returns a reference to it
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
    public GameObject RefrenceObject()//this is the object that comets refer to when calculating distance to player
    {
        return Player;
    }

    public float despawnDistance()//distance at which the comets despawn entirely
    {
        return despawndistance;
    }
    public float spawnDistance()//distance at which they appear
    {
        return spawndistance;
    }
}
