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
            GetComponent<Animator>().SetTrigger("atacking");
            Collider2D[] colliders = new Collider2D[3];
            transform.Find("EspadaArea").gameObject.GetComponent<Collider2D>()
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
    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Objeto"))
        {

            Destroy(collision2D.gameObject);

        }

        if (collision2D.gameObject.CompareTag("tijolao"))
        {

            Destroy(collision2D.gameObject);
            UnityEngine.SceneManagement.SceneManager.LoadScene("Fase2");
        }
    }

}
 