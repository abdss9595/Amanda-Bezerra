using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerF2 : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Animator animator;
    private bool eLadoDireito;
    

    private float horizontal;

    [SerializeField]

    private float velocidade = 0;




    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        eLadoDireito = transform.localScale.x > 0;
    }

    void FixedUpdate()
    {
        
        horizontal = Input.GetAxis("Horizontal");
        Movimentar(horizontal);
        MudarDirecao(horizontal);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Animator>().SetTrigger("atacking2");
            Collider2D[] colliders = new Collider2D[3];
            transform.Find("Espada2").gameObject.GetComponent<Collider2D>()
                .OverlapCollider(new ContactFilter2D(), colliders);
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i] != null && colliders[i].gameObject.CompareTag("Esqueletos"))
                {
                    Destroy(colliders[i].gameObject);
                }
            }
        }

    }

    private void Movimentar(float h)
    {
        
        rb2D.velocity = new Vector2(h * velocidade, rb2D.velocity.y);

        animator.SetFloat("velocidade", Mathf.Abs(h));
    }

    private void MudarDirecao(float horizontal)
    {
        if (horizontal > 0 && !eLadoDireito || horizontal < 0 && eLadoDireito)
        {
            eLadoDireito = !eLadoDireito;
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }

    }
    
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            rb2D.velocity = new Vector2(0, 5f);
            //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }

    }

    void Update()
    {
        Jump();
    }
}
