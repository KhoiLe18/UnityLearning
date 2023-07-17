using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UpAndDown : MonoBehaviour
{
    [SerializeField] private float maxVal;
    [SerializeField] private float minVal;
    [SerializeField] private float SpeedOffset;
    void MoveToAndFro() {
        this.transform.position = new Vector3(transform.position.x, 
                                              Mathf.PingPong(Time.time * SpeedOffset, maxVal - minVal)+minVal, 
                                              transform.position.z);
        //Debug.Log(Mathf.PingPong(Time.time, maxVal - minVal));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveToAndFro();
    }
}
