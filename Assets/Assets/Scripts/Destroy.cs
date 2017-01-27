using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
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
