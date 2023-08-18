using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    [HideInInspector] public bool HasHitFinishLine = false;
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Pass":
                //Debug.Log("Pass");
                break;

            case "Fuel":
                GameManager.instance.fuelManager.rocketFuel += 30;
               // Debug.Log(GameManager.instance.fuelManager.rocketFuel);
                break;

            case "Finish":
                {
                    HasHitFinishLine = true;
                    GameManager.instance.playerRespawnManager.WinSequence();

                }
                // Debug.Log("Finish");
                break;

            default: //fail
                     // Debug.Log("Fail");
                {
                   GameManager.instance.playerRespawnManager.LoadScene();

                    HasHitFinishLine = false;
                }
              
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {}


}
