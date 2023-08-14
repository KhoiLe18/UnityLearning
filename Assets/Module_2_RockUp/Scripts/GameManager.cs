using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour


{
    public RocketMovement rocketMovement;
    public CollisionManager collisionManager;
    public FuelManager fuelManager;
    public static GameManager instance;



    void Awake()
    {
        if (instance == null)
         {
        instance = this;
        }
        else
        {
            Destroy(instance );
        }
       
    }
}

    