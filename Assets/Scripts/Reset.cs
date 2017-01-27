using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
        }
	}

    public static void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
