using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

    [SerializeField]
    private Image currentSpeedBar;
    [SerializeField]
    private Button respawn;

    private float currentSpeed = 100f;
    private float maxCurrentSpeed = 100f;

	// Use this for initialization
	void Start () {
        UpdateSpeedBar();
        respawn.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	private void UpdateSpeedBar () {
        float ratio = SpaceShipMovement.speed / SpaceShipMovement.maxSpeed;
        currentSpeedBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
	}

    private void DecreaseSpeed(float decrease)
    {
        //currentSpeed -= decrease;
        if (SpaceShipMovement.speed < 50)
            {
                currentSpeed = 0;
                Debug.Log("slow");
            }

        UpdateSpeedBar();
    }

    public void Respawn()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    private void IncreaseSpeed(float increase)
    {
        //currentSpeed += increase;
        if(SpaceShipMovement.speed > SpaceShipMovement.maxSpeed)
        {
            currentSpeed = maxCurrentSpeed;
            Debug.Log("fast");
        }

        UpdateSpeedBar();
    }
}
