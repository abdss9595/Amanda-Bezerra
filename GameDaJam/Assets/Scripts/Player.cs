using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private Animator animator;
    private bool eLadoDireito;

   private float horizontal;

    [SerializeField]

    private float velocidade = 0;

    


    void Start () 
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        eLadoDireito = transform.localScale.x > 0;
    }

    void FixedUpdate ()
    {
        horizontal = Input.GetAxis("Horizontal");
        Movimentar(horizontal);
        MudarDirecao(horizontal);
        
    }

    private void Movimentar(float h)
    {
        rb2D.velocity = new Vector2(h*velocidade,rb2D.velocity.y);

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

    

  

    

    
}
 