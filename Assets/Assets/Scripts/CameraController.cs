using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_controller : MonoBehaviour {

	public Transform Target;
	public float LokSmooth = 0.09f;
	public Vector3 OffsetFromTarget = new Vector3 (0, 6, -8);
	public float xTilt = 10;

	Vector3 _destination = Vector3.zero;
	CharacterController _charController;
	float rotateVel = 0;
    
    public Camera_controller(float rotateVel)
    {
        this.rotateVel = rotateVel;
    }

    void Start()
	{
		SetCameraTarget (Target);
	}

    private void SetCameraTarget(Transform t)
	{
		Target = t;

		if (Target != null) {
			if (Target.GetComponent<CharacterController> ()) {
				_charController = Target.GetComponent<CharacterController> ();
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
		_destination = _charController.TargetRotation * OffsetFromTarget;
		_destination += Target.position;
		transform.position = _destination;
	}

	void LookAtTarget()
	{

	}
}
