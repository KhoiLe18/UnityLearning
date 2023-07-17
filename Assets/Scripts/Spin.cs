using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private Material hitMat2;
    [SerializeField] private float xvar;
    [SerializeField] private float yvar;
    [SerializeField] private float zvar;
    // Start is called before the first frame update

    void SpinObj() {
        this.transform.Rotate(xvar, yvar, zvar);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpinObj();
    }

    //void OnCollisionEnter(Collision c)
    //{
    //    //Assign new material
    //    this.GetComponent<MeshRenderer>().material = hitMat2;
    //}
}
