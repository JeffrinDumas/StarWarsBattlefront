using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserbolt : MonoBehaviour {

    [SerializeField]
    private spawn spawner;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "laserbolt")
        {
            GameObject.Destroy(col.gameObject);
        }
    }
}

