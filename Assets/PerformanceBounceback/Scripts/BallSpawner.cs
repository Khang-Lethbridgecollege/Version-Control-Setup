using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

    

    public GameObject pooledBall; //the prefab of the object in the object pool
    public static BallSpawner SharedInstance;
    public List<GameObject> pooledObjects;
    public static int ballNumber = 0;
    public int amountToPool;
    void Awake()
    {
        SharedInstance = this;
    }
    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
        for (int i = 0; i < amountToPool; i++)
        {
            tmp = Instantiate(pooledBall);
            tmp.SetActive(false);
            pooledObjects.Add(tmp);
          
        }
        InvokeRepeating("SpawnBall", 0f, 0.5f);
    }
    
   	
	// Update is called once per frame
	private void Update () {
	
	}


    public GameObject GetPooledObject()
    {
        //1
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            //2
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        //3   
        return null;
    }


    void SpawnBall()
    {
        GameObject ball = BallSpawner.SharedInstance.GetPooledObject();
        if (ball != null)
        {
            ball.transform.position = transform.position;
            ball.transform.rotation = transform.rotation;
            ball.SetActive(true);
        }
       /*
        ballNumber++;
        if (ballNumber >= amountToPool)
        {
            amountToPool = 0;
        }
       */
    }


}
