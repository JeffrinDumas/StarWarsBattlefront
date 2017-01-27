using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathCamera : MonoBehaviour {
    
    public Button respawn;

    [SerializeField]
    private GameObject thirdPersonCamera;
    private bool couroutineHasStarted = false;

    private float speed = 10f;

    void Start()
    {
        CameraBackwards();
    }

    public void CameraBackwards()
    { 
        StartCoroutine("MoveBack");
    }
    
	IEnumerator MoveBack()
    {
        if(couroutineHasStarted == false) {
            transform.position = thirdPersonCamera.transform.position;
            transform.rotation = thirdPersonCamera.transform.rotation;
            for (int i = 0; i < 200; i++)
            {
                transform.position -= transform.forward * Time.deltaTime * speed;

                yield return new WaitForSeconds(0f);
                couroutineHasStarted = true;

                //StopAllCoroutines();
            }
            Debug.Log("HOIII");
            respawn.gameObject.SetActive(true);
        }
    }
}
