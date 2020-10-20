using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptEnemy : MonoBehaviour
{
    public float velocidade = 5;
    private Rigidbody2D rbd;
    public LayerMask mascara;
    public LayerMask mascaraKill;
    public float distancia = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        transform.Rotate(new Vector2(0, 180));
    }


    // Update is called once per frame
    void Update()
    {
        rbd.velocity = new Vector2(velocidade, rbd.velocity.y);

        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, -transform.right, distancia, mascara);
        if (hit.collider != null)
        {
            velocidade = -1 * velocidade;
            rbd.velocity = new Vector2(velocidade, 0);
            this.transform.Rotate(new Vector2(0, 180));
        }

        hit = Physics2D.Raycast(transform.position, -transform.right, distancia, mascaraKill);
        if (hit.collider != null)
        {
            Destroy(hit.collider.gameObject);
        }
        hit = Physics2D.Raycast(transform.position, transform.right, distancia, mascaraKill);
        if (hit.collider != null)
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
