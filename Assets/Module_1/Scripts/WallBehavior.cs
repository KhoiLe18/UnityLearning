using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBehavior : MonoBehaviour
{
	public Material hitMat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

		//void OnCollisionEnter(Collision c) {
		//	Debug.Log("collide");

		//	//Amend exisitng material
		//	this.GetComponent<MeshRenderer>().material.color = new Color(0.2f, 0.11f, 0.56f, 1);//Color.red;

		//	//Assign new material
		//	this.GetComponent<MeshRenderer>().material = hitMat;
		//}

		//void OnCollisionStay() {
		//	Debug.Log("Colliding");
		//}
		//void OnCollisionExit() {
		//	Debug.Log("Exit collision");
		//}

		//void OnTriggerEnter() {
		//	Debug.Log("Enter trigger");
		//}

		//void OnTriggerStay() {
		//	Debug.Log("Is in trigger");
		//}
		//void OnTriggerExit() {
		//	Debug.Log("Exit trigger");
		//}
}
