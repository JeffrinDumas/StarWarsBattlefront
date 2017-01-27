using UnityEngine;
using System.Collections;

public class VectorMovement : MonoBehaviour {
    private Vector2 position = new Vector2();
    private Vector2 velocity = new Vector2(2, 0);
    private float mass = 20;
    private float maxSpeed = 5;
    public Transform Target;
    // Use this for initialization
    void Start () {
        velocity = new Vector2(1, 1) * maxSpeed;
    }
	
	// Update is called once per frame
	void Update ()
        {

        Seek();

        position += velocity * Time.deltaTime;
        transform.position = position;
    }

    void Seek()
    {
        Vector2 desiredStep = Target.position - transform.position;
        desiredStep.Normalize();
        Vector2 desiredVelocity = desiredStep * maxSpeed;
        Vector2 steeringForce = desiredVelocity - velocity;
        velocity = velocity + steeringForce / mass;
    }

}
