using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemY : MonoBehaviour
{

    private Transform myTransform;
    private Transform target;
    private int maxDistance = 1;
    private int rotationSpeed = 30;
    private int moveSpeed = 30;
    private Transform collision;


    void Awake()
    {
        myTransform = transform;
    }

    // Use this for initialization
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");

        target = go.transform;

        maxDistance = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(target.position, myTransform.position, Color.yellow);

        //Look at target
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
            Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);

        if (Vector3.Distance(target.position, myTransform.position) > maxDistance)
        {
            //Move towards target
            myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
        }
    }
}
