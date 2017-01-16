using UnityEngine;
using System.Collections;

public class SeekBehaviourScript : MonoBehaviour
{

    public Transform crossHair;

    private Vector3 target;
    private float maxSpeed = 1;
    private float mass = 500;
    private Vector3 velocity = new Vector3();




    // Update is called once per frame
    void Update()
    {

        Seek();
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10f;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            target = mousePosition;

            Instantiate(crossHair, mousePosition, Quaternion.identity);
        }
    }


    void Seek()
    {

        // we berekenen eerst de afstand/Vector tot de 'target' (in dit voorbeeld de andere cubus)  
        Vector3 desiredStep = target - velocity;

        // deze desiredStep mag niet groter zijn dan de maximale Speed
        //
        // als een vector ge'normalized' is .. dan houdt hij dezelfde richting
        // maar zijn lengte/magnitude is 1
        desiredStep.Normalize();

        // als je deze weer vermenigvuldigt met de maximale snelheid dan
        // wordt de lengte van deze Vector maxSpeed (aangezien 1 x maxSpeed = maxSpeed)
        // de x en y van deze Vector wordt zo vanzelf omgerekend
        Vector3 desiredVelocity = desiredStep * maxSpeed;

        // bereken wat de Vector moet zijn om bij te sturen om bij de desiredVelocity te komen
        Vector3 steeringForce = desiredVelocity - velocity;

        // uiteindelijk voegen we de steering force toe maar wel gedeeld door de 'mass'
        // hierdoor gaat hij niet in een rechte lijn naar de target
        // hoe zwaarder het object hoe moeilijker hij kan bijsturen
        velocity = velocity + steeringForce / mass;

        transform.position = transform.position + velocity;

        if (transform.position == target)
        {
            maxSpeed = 0;
        }



    }
}