using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour 
{
	public List<GameObject> checkpoints = new List<GameObject>();
	private int currentCheckpoint = 0;
	public GameObject checkPrefab;
	private Rigidbody rbody;

	void Start () {
        checkpoints.Add (new GameObject());
		checkpoints.Add (new GameObject());
		checkpoints.Add (new GameObject());
		checkpoints.Add (new GameObject());
		checkpoints.Add (new GameObject());

		checkpoints[0].transform.position = new Vector3 (0, 20, 25);
		checkpoints[1].transform.position = new Vector3 (10, 25, 25);
		checkpoints[2].transform.position = new Vector3 (15, 30, 25);
		checkpoints[3].transform.position = new Vector3 (20, 35, 25);
		checkpoints[4].transform.position = new Vector3 (25, 40, 25);
	
		
		rbody = GetComponent<Rigidbody>();

		//GameVariables.checkpoint = new Vector3 (0, 4.3f, 0);
	}
	
	// Update is called once per frame

	void OnTriggerEnter(Collider col) {
       
		if(col.gameObject.tag == "Checkpoint"){
			currentCheckpoint++;
			showCheckpoint ();
		//transform.position = GameVariables.checkpoint;
		}



	}
	public void showCheckpoint(){
		GameObject.Instantiate(checkPrefab, checkpoints[currentCheckpoint].transform);
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up);
        }
    }
}


