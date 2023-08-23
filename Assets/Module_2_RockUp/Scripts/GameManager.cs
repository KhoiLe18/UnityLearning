using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour


{
    public RocketMovement rocketMovement;
    public CollisionManager collisionManager;
    public FuelManager fuelManager;
    public PlayerRespawnManager playerRespawnManager;
    public static GameManager instance;
    public int MyLives ;


    void Awake()
    {
        if (instance == null)
         {
        instance = this;
            MyLives = 5;
        }
       
        DontDestroyOnLoad(instance);

       

    }

}

    