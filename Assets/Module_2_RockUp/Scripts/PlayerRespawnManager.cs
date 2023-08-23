using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawnManager : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        
        if (GameManager.instance.MyLives > 0)
        {

            GameManager.instance.MyLives -= 1;
            Debug.Log(" My Lives = " + GameManager.instance.MyLives);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }

        else 
        {
            Debug.Log("Fail");
        }
    }

    public void WinSequence()
    {
      
        Debug.Log("Winner");

    }
}
