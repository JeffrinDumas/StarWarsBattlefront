using UnityEngine;

namespace Assets.Assets.Scripts
{
    public class EnemyMovement : MonoBehaviour {

        public Transform Target;
        public float MaxSpeed = 15;
        public float Mass = 50;
        public int RotationSpeed;
        public int Maxdistance;
        public float AttackTime;
        public float CoolDown;
        private readonly Transform _myTransform;

        public EnemyMovement(Transform myTransform)
        {
            this._myTransform = myTransform;
        }


        private void Start()
        {
            GameObject go = GameObject.FindGameObjectWithTag("Player");
            Target = go.transform;
     
            AttackTime = 0;
            CoolDown = 4.0f;
        }

        private void Update()
        {
            Seek();

            Debug.DrawLine(Target.position, _myTransform.position, Color.red);
            var dist = Vector3.Distance(Target.position, transform.position);
            if (dist < 3)
            {
                Vector3 targetDir = Target.position - _myTransform.position;
                targetDir.y = 0;
                _myTransform.rotation = Quaternion.Slerp(_myTransform.rotation, Quaternion.LookRotation(targetDir),
                    RotationSpeed * Time.deltaTime);
                if (dist > 2)
                {
                    _myTransform.position += _myTransform.forward * MaxSpeed * Time.deltaTime;
                }
            }
        }
    
        void Seek()
        {

            Vector3 desiredStep = Target.position - GetComponent<Rigidbody>().position;


            desiredStep.Normalize();

            Vector3 desiredVelocity = desiredStep * MaxSpeed;


            Vector3 steeringForce = desiredVelocity - GetComponent<Rigidbody>().velocity;


            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity + steeringForce / Mass;
        }
    }
}
