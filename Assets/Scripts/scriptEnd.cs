using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scriptEnd : MonoBehaviour
{
    private Scene currentScene;
    private int buildIndex;
    private void Start()
    {
         currentScene = SceneManager.GetActiveScene();
         buildIndex = currentScene.buildIndex;
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
            SceneManager.LoadScene(buildIndex + 1);
    }


    
}
