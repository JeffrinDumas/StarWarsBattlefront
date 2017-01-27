using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Shooting : MonoBehaviour {

    [SerializeField]
    private GameObject laser;
    [SerializeField]
    private GameObject muzzle;

    [SerializeField]
    private AudioClip shoot;
    private AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Shoot");
            GameObject projectile = Instantiate(laser, muzzle.transform.position, muzzle.transform.rotation) as GameObject;
            audio.PlayOneShot(shoot, 1f);
        }
	}
}
