using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    Rigidbody rocket;
    public float ThrustOffset = 1f;
    public float RotationOffset = 1f;
    public AudioSource ThrustAudioSource = null;
     

    
    void ProcessMovement() {

        //Thrust
        if (Input.GetKey(KeyCode.Space))
        {
            //Debug.Log("Space");

            rocket.AddRelativeForce(Vector3.up * ThrustOffset * Time.deltaTime);
            if (ThrustAudioSource != null & !ThrustAudioSource.isPlaying)
            {
                ThrustAudioSource.Play();

            }
            

        }
        else
        {
            ThrustAudioSource.Pause();
            //ThrustAudioSource.Stop();
        }
    }

    void ProcessRotation() {
        //Left
        if (Input.GetKey(KeyCode.A)) 
        {
            CalculateRotation(1);
            //transform.Rotate(0 ,0 ,1);
            //Debug.Log("Rotate Left");
        }

        //Right
        if (Input.GetKey(KeyCode.D))
        {
            CalculateRotation(-1);
            //transform.Rotate(0 ,0 ,-1);
            //Debug.Log("Rotate Right");
        }
    }

    void CalculateRotation(int d)
    {
        rocket.freezeRotation = true;
        transform.Rotate(d * Vector3.forward * RotationOffset * Time.deltaTime);
        rocket.freezeRotation = false;
    }

    void Awake()
    {
        rocket = this.GetComponent<Rigidbody>();
        //Debug.unityLogger.logEnabled = false;
        
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
