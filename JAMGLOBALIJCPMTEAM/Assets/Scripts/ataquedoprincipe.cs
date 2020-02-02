using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ataquedoprincipe : MonoBehaviour
{

    private void Update()
    {
        YouWin();   
    }
    public void YouWin()
    {
        if (pornavidadoinimigo.vida <= 0)
        {
            SceneManager.LoadScene("You Win");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        pornavidadoinimigo.vida -= 3f;


    }
}
