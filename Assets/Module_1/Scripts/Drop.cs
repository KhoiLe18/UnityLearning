using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    void dropMe() {
        this.gameObject.GetComponent<MeshRenderer>().enabled = true;
        this.gameObject.GetComponent<Rigidbody>().useGravity = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("dropMe", 5);

        StartCoroutine(dropMeEnum());
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time);
        //if (Time.time >= 5) {
        //    this.gameObject.GetComponent<MeshRenderer>().enabled = true;
        //    this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        //}
    }

    IEnumerator dropMeEnum ()
    {
        yield return null;//new WaitForSeconds(5);
        dropMe();
        //yield return new WaitForSeconds(1);
        //Debug.Log("Finished");
    }

}
