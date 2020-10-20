using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMusic : MonoBehaviour
{   
    private new AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        DontDestroyOnLoad(audio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
