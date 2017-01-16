using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {

    [SerializeField]
    private GameObject muzzle;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Shoot");
            GameObject projectile = Instantiate(muzzle, transform.position, transform.rotation) as GameObject;
        }
	}
}
