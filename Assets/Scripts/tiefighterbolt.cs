using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiefighterbolt : MonoBehaviour
{
    public GameObject tiefighterlaserbolt;
    private Transform myTransform;
    public float force;

	void Start ()
	{
	    setinitialReferences();

	}
	

	void Update () {
	    if (Input.GetKeyDown(KeyCode.Mouse0))
	    {
	        spawnLazerBolt();
	    }
	}

    void setinitialReferences()
    {
        myTransform = transform;
    }

    void spawnLazerBolt()
    {
        GameObject go = (GameObject)Instantiate(tiefighterlaserbolt, myTransform.TransformPoint(0, 0, 0.5f), myTransform.rotation);
        go.GetComponent<Rigidbody>().AddForce(myTransform.forward * force, ForceMode.Impulse);
        Destroy(go, 3);
    }
}
