using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controller : MonoBehaviour {

	public Transform target;
	public float lokSmooth = 0.09f;
	public Vector3 offsetFromTarget = new Vector3 (0, 6, -8);
	public float xTilt = 10;

	Vector3 destination = Vector3.zero;
	CharacterController charController;
	float rotateVel = 0;

	void Start()
	{
		SetCameraTarget (target);
	}

	void SetCameraTarget(Transform t)
	{
		target = t;

		if (target != null) {
			if (target.GetComponent<CharacterController> ()) {
				charController = target.GetComponent<CharacterController> ();
			} else
				Debug.LogError ("The cameraś target needs a character controller");
		} else
			Debug.LogError ("Your camera needs a target.");
	}

	void LateUpdate()
	{
		//moving
		MoveToTarget();
		//rotaing
		LookAtTarget();
	}

	void MoveToTarget()
	{
		destination = charController.TargetRotation * offsetFromTarget;
		destination += target.position;
		transform.position = destination;
	}

	void LookAtTarget()
	{

	}
}
