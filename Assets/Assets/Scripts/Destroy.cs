using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {
    public float lifetime = 6;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, lifetime);
	}
	
	
}
