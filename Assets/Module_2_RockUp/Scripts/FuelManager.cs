using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelManager : MonoBehaviour
{
    Rigidbody rocket;
    public float rocketFuel = 100;
    public float fuelOffSet = 1; 

   public void ExpenseFuel()
    {
        rocketFuel -= 0.1f * fuelOffSet;
    }

    void FuelProcessing()
    {
        //if (rocketFuel % 10 == 0)
        //{
            Debug.Log(rocketFuel);
        //}

        if (rocketFuel <= 0)
        {
            //GameManager.instance.rocketMovement.rocket.constraints = RigidbodyConstraints.FreezePositionY;
            GameManager.instance.rocketMovement.enabled = false;
            Debug.Log("Out of Fuel");
        }
    }

    void Start()
    {
        //rocket = GameManager.instance.rocketMovement.rocket;
        StartCoroutine(FuelHandling());
    }

    IEnumerator FuelHandling()
    {
        yield return new WaitForSeconds(1f);
        FuelProcessing();
        if (rocketFuel > 0) { 
        
        StartCoroutine(FuelHandling());

        }

    }

    private void FixedUpdate()
    {
        FuelProcessing();
    }
}

  
