using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Ball, RPlank, LPlank;

    private void CreateBall() {
       GameObject go= Instantiate(Ball, new Vector3(RPlank.transform.position.x, RPlank.transform.position.y + 1, RPlank.transform.position.z), Quaternion.identity);
        go.tag = "Ball";
        go.name = "Myfood";
    }
    private void Start()
    {
        StartCoroutine( TimeCreateBall());

    }

    private void Update()
    {
    }

    IEnumerator TimeCreateBall() { 
        CreateBall();
        yield return new WaitForSeconds(0.5f);

        if (Time.time > 15)
        {
            StopCoroutine(TimeCreateBall());
        }
        else
        {
            StartCoroutine(TimeCreateBall());

        }
    }
}

