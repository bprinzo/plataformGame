using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptGameControl : MonoBehaviour
{
    private bool pausa = false;
    public GameObject MC;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausa)
            {
                Time.timeScale = 1;
                SceneManager.UnloadSceneAsync(4);
            }
            else
            {
                Time.timeScale = 0;
                SceneManager.LoadSceneAsync(4, LoadSceneMode.Additive);
                PlayerPrefs.SetInt("index", SceneManager.GetActiveScene().buildIndex);
                PlayerPrefs.Save();
            }
            pausa = !pausa;
        }

        if(MC == null)
        {
            SceneManager.LoadScene(5);
        }
    }
}
