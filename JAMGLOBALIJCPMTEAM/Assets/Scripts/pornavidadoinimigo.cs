using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pornavidadoinimigo : MonoBehaviour
{
    Image barra;
    float maxbarra = 100f;
    public static float vida;

    void Start()
    {

        barra = GetComponent<Image>();
        vida = maxbarra;

    }
    void Update()
    {
        barra.fillAmount = vida / maxbarra;



    }

}