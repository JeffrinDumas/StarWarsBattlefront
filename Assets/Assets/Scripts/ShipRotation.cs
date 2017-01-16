using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipRotation : MonoBehaviour {

    private Rigidbody rb;
	
    void Start()
    {
        Cursor.visible = false;

        rb = GetComponent<Rigidbody>();
    }

	void FixedUpdate () {

        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        rb.AddRelativeTorque(0, h * 20, v * 20);

        rb.AddForce(transform.forward);

	}
}
