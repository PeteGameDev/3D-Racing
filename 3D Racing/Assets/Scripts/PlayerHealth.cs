using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //wanting to reload the scene on death.

public class PlayerHealth : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y < -10f)//if player is lower than -10 on the y axis
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //reload the active scene (current scene)
        }
    }
}
