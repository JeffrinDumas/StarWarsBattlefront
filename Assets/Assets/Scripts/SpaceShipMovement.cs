using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour {

    [SerializeField]
    private float speed;
    private float maxSpeed = 35;
    private float minSpeed = 10;

    private float decreaseSpeed = 1f;
    private float increaseSpeed = 1;

    private float decreaseCameraDistance = 0.5f;
    private float increaseCameraDistance = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.W) && speed <= maxSpeed)
        {
            speed = speed + increaseSpeed;
            CamFollow.distance = CamFollow.distance + increaseCameraDistance;
        }
        if(Input.GetKey(KeyCode.S) && speed >= minSpeed)
        {
            speed = speed - decreaseSpeed;
            CamFollow.distance = CamFollow.distance - decreaseCameraDistance;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
        }
	}
}
