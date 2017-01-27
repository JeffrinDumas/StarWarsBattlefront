using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    [SerializeField]
    private spawn spawner;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            GameObject.Destroy(col.gameObject);
            spawner.SpawnEnemy();
        }
    }
}

