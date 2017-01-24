using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public int NumberOfEnemies;
    public float spawnRadius = 2;
    private Vector3 spawnPosition;


	void Start ()
    {
		spawnObject();
	}
	
	
	void Update ()
    {
		
	}

    void spawnObject()
    {
        for (int i = 0; i < NumberOfEnemies; i++)

        {
            spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
            //Vector3 adjustedPos = new Vector3(spawnPosition.x, 1, spawnPosition.z);
            Instantiate(ObjectToSpawn, spawnPosition, Quaternion.identity);
        }
    }
}

