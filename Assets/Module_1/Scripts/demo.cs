using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo : MonoBehaviour
{
public int year;
		void Awake() {

		}

    // Start is called before the first frame update
    void Start()
    {
			car c = new car();
			c.Init();
			c.show();

		
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class vehicle {
	protected int wheels;
	protected string length;
}

public class car : vehicle {
	public void Init() {
		wheels = 4;
		length = "4m";


	}


	public void show(){

		Debug.Log("wheels :"+ wheels +"  lentgh"+ length);
	}

}

