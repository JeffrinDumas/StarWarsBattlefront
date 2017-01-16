using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour {
    
    Vector2 mouseLook;
    Vector2 smoothV;

    public float sensivityX = 1.5f;
    public float sensivityY = 1.0f;
    public float smoothing = 2.0f;

    GameObject camera;

	// Use this for initialization
	void Start () {
        Cursor.visible = false;
        camera = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector2.Scale(md, new Vector2(sensivityX * smoothing, sensivityY * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -45f, 45f);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        camera.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, camera.transform.up);
	}
}
