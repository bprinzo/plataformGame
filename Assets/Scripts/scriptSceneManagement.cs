using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scriptSceneManagement : MonoBehaviour
{
   
    public void iniciar()
    {
        SceneManager.LoadScene(1);
    }
    public void sair()
    {
        Application.Quit();
    }

    public void retry()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("index"));
        Time.timeScale = 1;
    }

}
