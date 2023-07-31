using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    Rigidbody rocket;
    private int rocketFuel = 100;
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Pass":
                Debug.Log("Pass");
                break;

            case "Fuel":
                rocketFuel += 30;
                Debug.Log(rocketFuel);
                break;

            case "Finish":
                Debug.Log("Finish");
                break;

            default: //fail
                Debug.Log("Fail");
                break;
        }
    }

    void ExpenseFuel() {
        rocketFuel--;
    }

    void FuelProcessing() {
        if (rocketFuel % 10 == 0)
        {
            Debug.Log(rocketFuel);
        }

        if (rocketFuel >= 0)
        {
            rocket.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        ExpenseFuel();
    }

    // Update is called once per frame
    void Update()
    {
        FuelProcessing();
    }
}
