using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class scriptCircularPlatform : MonoBehaviour
{
    private float count = 0;
    public float velocidade = 3;
    public Vector2 posInicial;
    public float width = 1;
    public float heigh = 1;
    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        count += velocidade * Time.deltaTime;

        float posX = Mathf.Cos(count) * width;
        float posY = Mathf.Sin(count) * heigh;

        Vector2 posAtual = new Vector2(posX, posY);

        transform.position = posInicial + posAtual;

        if (count >= 2 * Mathf.PI)
            count = 2 * Mathf.PI - count;

    }
}
