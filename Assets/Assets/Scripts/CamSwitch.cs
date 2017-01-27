using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour {

    [SerializeField]
    private Camera firstPersonCamera;
    [SerializeField]
    private Camera thirdPersonCamera;
    [SerializeField]
    private Camera deathCamera;
    private DeathCamera dc;

    private bool camSwitch = true;

	// Use this for initialization
	void Start () {
        thirdPersonCamera.gameObject.SetActive(true);
        firstPersonCamera.gameObject.SetActive(false);
        deathCamera.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (camSwitch)
            {
                thirdPersonCamera.gameObject.SetActive(false);
                firstPersonCamera.gameObject.SetActive(true);

                Debug.Log("1st");
            }
            else 
            {
                thirdPersonCamera.gameObject.SetActive(true);
                firstPersonCamera.gameObject.SetActive(false);

                Debug.Log("3rd");
            }
           

            camSwitch = !camSwitch;
        }
        if (PlayerDeath.death == true)
        {
            deathCamera.gameObject.SetActive(true);
            thirdPersonCamera.gameObject.SetActive(false);
            dc = GameObject.Find("DeathCamera").GetComponent<DeathCamera>();
            dc.CameraBackwards();
        }
    }
}
