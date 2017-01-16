using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public Transform target;
    public float maxSpeed = 15;
    public float mass = 50;
    public int rotationSpeed;
    public int maxdistance;
    public float attackTime;
    public float coolDown;
    private Transform myTransform;

    void Awake()
    {
        myTransform = transform;
    }


    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        target = go.transform;
     
        attackTime = 0;
        coolDown = 4.0f;
    }

    void Update()
    {
        Seek();

        Debug.DrawLine(target.position, myTransform.position, Color.red);
        float dist = Vector3.Distance(target.position, transform.position);
        if (dist < 3)
        {
           
            Vector3 targetDir = target.position - myTransform.position;
            targetDir.y = 0; 
            myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(targetDir), rotationSpeed * Time.deltaTime);
            if (dist > 2)
            { 
                myTransform.position += myTransform.forward * maxSpeed * Time.deltaTime;
            }
        }
    }
    
    void Seek()
    {

        Vector3 desiredStep = target.position - GetComponent<Rigidbody>().position;


        desiredStep.Normalize();

        Vector3 desiredVelocity = desiredStep * maxSpeed;


        Vector3 steeringForce = desiredVelocity - GetComponent<Rigidbody>().velocity;


        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity + steeringForce / mass;
    }
}
