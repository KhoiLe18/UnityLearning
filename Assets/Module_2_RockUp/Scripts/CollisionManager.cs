using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Pass":
                Debug.Log("Pass");
                break;

            case "Fuel":
                Debug.Log("Fuel");
                break;

            case "Finish":
                Debug.Log("Finish");
                break;

            default: //fail
                Debug.Log("Fail");
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
