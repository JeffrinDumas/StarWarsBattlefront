using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour {

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    public static float distance = 12.5f;

	// Use this for initialization
	void Start () {
        camTransform = transform;
        cam = Camera.main;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 dir = new Vector3(0, 0, - distance);
	}
}
