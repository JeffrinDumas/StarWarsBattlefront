using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject objectToSpawn;
    public int maxNumberOfEnemies;
    public float spawnRadius = 2;
    private Vector3 spawnPosition;

    void Start()
    {
        for (int i = 0; i < maxNumberOfEnemies; i++)
        {
            SpawnEnemy();
        }
    }


    public void SpawnEnemy()
    {
        spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
        //Vector3 adjustedPos = new Vector3(spawnPosition.x, 1, spawnPosition.z);
        GameObject enemy = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

    }
   
}

