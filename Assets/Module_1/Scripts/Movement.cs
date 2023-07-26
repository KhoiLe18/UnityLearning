using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Material hitMatWall;
    [SerializeField] private Material hitMatSpinner;
 
    private int hitCounter = 0;

    void CollectBall() { 
            
    }

    public GameObject Sphere;
		[SerializeField]private float xvar = 0;
		[SerializeField]private float yvar = 0;
		[SerializeField]private float zvar = 0;
		private const float OFFSET = 5;

    void OnCollisionEnter(Collision c) {
        Debug.Log("collide with mat "+ c.gameObject.GetComponent<MeshRenderer>().material.name);

        if (c.gameObject.tag == "Spinner")
        {
            if (c.gameObject.GetComponent<MeshRenderer>().material.name != "Spinner (Instance)")
            {
                hitCounter++;

            }


            c.gameObject.GetComponent<MeshRenderer>().material = hitMatSpinner;
          
            
           
            
        }

        if (c.gameObject.tag == "Wall")
        {
            if (c.gameObject.GetComponent<MeshRenderer>().material.name != "Wall2 (Instance)")
            {
                hitCounter++;
            }

            c.gameObject.GetComponent<MeshRenderer>().material = hitMatWall;

        }

        if (c.gameObject.tag == "Ball") {
            Debug.Log("Eat Ball");

            hitCounter--;

            Destroy(c.gameObject);

        }

        Debug.Log(hitCounter);

    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		xvar = Input.GetAxis("Horizontal") * Time.deltaTime * OFFSET; 
        Sphere.transform.Translate(xvar, yvar, zvar);

        zvar = Input.GetAxis("Vertical") * Time.deltaTime * OFFSET;
        Sphere.transform.Translate(xvar, yvar, zvar);

    }
}
