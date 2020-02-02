using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // chamando telas
    public void ChamaJogo()
        {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Storie");
        }

    public void ChamaHTP()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Settings");
    }

    public void ChamaMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Samplescene");
    }

    public void ChamaSair()
    {
        Application.Quit();
    }

    public void ChamaJogo1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Fase1");

       
    }

    public void ChamaCreditos()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Credits");


    }

}
