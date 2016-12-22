using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		GameVariables.checkpoint = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x > 20) 
		{
			transform.position = GameVariables.checkpoint;
		}
	}
}
