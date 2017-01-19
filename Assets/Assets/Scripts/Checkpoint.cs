using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour 
{
	public List<Transform> checkpointPositions = new List<Transform>();
	private int currentCheckpoint = 0;
	public GameObject checkPrefab;
	private Rigidbody rbody;

	void Start () {
        //     checkpointPositions.Add( new Vector3 (0, 20, 25));
        //     checkpointPositions.Add(new Vector3(100, 25, 25));
        //     checkpointPositions.Add(new Vector3(150, 30, 25));
        //    checkpointPositions.Add(new Vector3(200, 35, 25));
        //      checkpointPositions.Add(new Vector3(250, 40, 25));

        Instantiate(checkPrefab, checkpointPositions[currentCheckpoint].position, checkpointPositions[currentCheckpoint].rotation);

        rbody = GetComponent<Rigidbody>();

		//GameVariables.checkpoint = new Vector3 (0, 4.3f, 0);
	}
	
	// Update is called once per frame

	void OnTriggerEnter(Collider col) {
       
		if(col.gameObject.tag == "Checkpoint"){
            
            GameObject.Destroy(col.gameObject);
            currentCheckpoint++;
			showCheckpoint ();
		//transform.position = GameVariables.checkpoint;
		}



	}
	public void showCheckpoint(){
        Instantiate(checkPrefab, checkpointPositions[currentCheckpoint].position, checkpointPositions[currentCheckpoint].rotation);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up);
        }
    }
}


