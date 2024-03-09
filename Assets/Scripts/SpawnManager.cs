using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class SpawnManager : MonoBehaviour
{
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    public GameObject obstacle;
    private float startTime = 1;
    private float repeatRate = 2;
    
   [SerializeField] PlayerController playerControllerScript;
    void Start()
    {
        InvokeRepeating("SpawnObstacle",startTime,repeatRate);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.isGameOver == false)
        { 
            Instantiate(obstacle, spawnPos, obstacle.transform.rotation);      
        }
        
    }
}
