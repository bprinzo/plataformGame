using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptCamera : MonoBehaviour
{
    public GameObject mc;
    public float offsetY = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicao = new Vector3(mc.transform.position.x, mc.transform.position.y + offsetY, -10);
        this.transform.position = posicao;
    }
}
