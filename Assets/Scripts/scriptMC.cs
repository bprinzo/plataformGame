using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMC : MonoBehaviour
{
    private Rigidbody2D rbd;
    private Animator anim;
    public float velocidade = 5;
    public float pulo = 250;
    private bool chao = true;
    private bool direita = true;
    public LayerMask mascara;
    public new AudioSource audio;
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        chao = true;
        transform.parent = collision.transform;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        chao = false;
        transform.parent = null;

    }

    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float velY;

        if (x == 0 && chao)
            anim.SetBool("idle", true);
        if(x != 0 && chao)
            anim.SetBool("idle", false);

        if (direita && x < 0 || !direita && x > 0)
        {
            direita = !direita;
            transform.Rotate(new Vector2(0, 180));
        }

        if (chao)
        {
            velY = 0;
        }
        else
        {
            velY = rbd.velocity.y;
        }

        rbd.velocity = new Vector2(x * velocidade, velY);

        
      
        if (velY < 0 && chao == false)
        {
            anim.SetBool("fall", true);
        }
        else
        {
            anim.SetBool("fall", false);
        }


        if (Input.GetKeyDown(KeyCode.Space) && chao)
        {
            chao = false;
            rbd.AddForce(new Vector2(0, pulo));
            anim.SetTrigger("jumping");
            anim.SetBool("idle", false);
        }

 

        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, -transform.up, 0.5f, mascara);
        if (hit.collider)
        {
            Destroy(hit.collider.gameObject);
            rbd.AddForce(new Vector2(0, pulo*2));
            audio.Play();
        }
    }
}
