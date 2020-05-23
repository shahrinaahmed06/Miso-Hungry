using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float spawnRate = .3f;
    float nextSpawn = 0f;
    public GameObject obstacle;
    public Transform[] spawnPoints;

    void Update()
    {
        

        //time since started the game 
        if (nextSpawn <= Time.time)
        {
            SpawnObstacle();
            nextSpawn = Time.time + spawnRate;
        }
    }

    void SpawnObstacle()
    {
        int random = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[random];
        //instantiate obstacle prefab
        Instantiate(obstacle, spawnPoint.position, spawnPoint.rotation) ;
    }

}
