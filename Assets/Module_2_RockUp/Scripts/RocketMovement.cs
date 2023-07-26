using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    Rigidbody rocket;
    public float ThrustOffset=100;

    void ProcessMovement() {

        //Thrust
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Space");

            rocket.AddRelativeForce(Vector3.up * ThrustOffset * Time.deltaTime);
        }
    }

    void ProcessRotation() {
        //Left
        if (Input.GetKey(KeyCode.A)) 
        {
            Debug.Log("Rotate Left");
        }

        //Right
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Rotate Right");
        }
    }

    void Awake()
    {
        rocket = this.GetComponent<Rigidbody>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
        ProcessRotation();
    }
}
