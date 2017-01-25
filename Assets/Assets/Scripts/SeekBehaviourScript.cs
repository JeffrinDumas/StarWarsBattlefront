using UnityEngine;
using System.Collections;

public class SeekBehaviourScript : MonoBehaviour
{

    public Transform target;
	public float maxSpeed	=	25;
	public float mass		=	50;
    public float min = 3;
    public Transform Target;

	void Start ()
	{
        
    }

	void Update ()
	{
        transform.LookAt(Target);
		Seek();
        
	}
	
	void Seek ()
	{
	
		Vector3 desiredStep	=	target.position - GetComponent<Rigidbody>().position;		
		
		desiredStep.Normalize();
		
	
		Vector3 desiredVelocity			=	desiredStep	*	maxSpeed;
		
	
		Vector3 steeringForce			=	desiredVelocity - GetComponent<Rigidbody>().velocity;

      
		
		GetComponent<Rigidbody>().velocity				=	GetComponent<Rigidbody>().velocity + steeringForce / mass;
	}
     void OnTriggerEnter(Collider other)
    {
        GameObject.FindGameObjectWithTag("Enemy");

    }
     void OnTriggerExit(Collider other)
    {
        GameObject.FindGameObjectWithTag("Enemy");
    }
}