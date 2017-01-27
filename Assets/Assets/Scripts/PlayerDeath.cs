using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {

    private CamFollow cam;
    public static bool death;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        death = false;
        cam = GameObject.Find("ThirdPersonCamera").GetComponent<CamFollow>();
    }
	
	// Update is called once per frame
	void OnCollisionEnter (Collision other) {
		if(other.gameObject.tag == "Wall")
        {
            death = true;
            Cursor.visible = true;
            cam.enabled = false;
            Destroy(gameObject);
        }
	}
}
