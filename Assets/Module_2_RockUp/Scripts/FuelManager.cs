using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelManager : MonoBehaviour
{
    Rigidbody rocket;
    public float rocketFuel = 100;
    public float fuelOffSet = 1; 
    public bool isOutOfFuel = false;
    public int countdownTimer = 0;
   public void ExpenseFuel()
    {
        rocketFuel -= 0.1f * fuelOffSet;
    }

    void FuelDebug()
    {
        Debug.Log(rocketFuel);
    }

    void OutOfFuel ()
    {
        //GameManager.instance.rocketMovement.rocket.constraints = RigidbodyConstraints.FreezePositionY;
        GameManager.instance.rocketMovement.enabled = false;
        isOutOfFuel = true;
        Debug.Log("Out of Fuel");
        GameManager.instance.rocketMovement.NoControl();
        StartCoroutine(RespawnCountdown());

    }

    void Start()
    {
        //rocket = GameManager.instance.rocketMovement.rocket;
        StartCoroutine(FuelHandling());
    }

    IEnumerator FuelHandling()
    {
        yield return new WaitForSeconds(1f);
        //FuelDebug();
        if (rocketFuel > 0) { 
        
        StartCoroutine(FuelHandling());

        }

    }

    IEnumerator RespawnCountdown()
    {
            yield return new WaitForSeconds(countdownTimer);

        if (GameManager.instance.collisionManager.HasHitFinishLine)
        {
            GameManager.instance.playerRespawnManager.WinSequence();
            Debug.Log("WinnerOutOfFuel");
        }
        else
        {
            GameManager.instance.playerRespawnManager.LoadScene();
            Debug.Log("LooserOutOfFuel");
        }

    }

    private void FixedUpdate()
    {
        if (rocketFuel > 0)
        {
            FuelDebug();
        }
        
        if (!isOutOfFuel && rocketFuel <= 0)
        {
            OutOfFuel();
        }
    }
}

  
