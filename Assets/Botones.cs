using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Boton : MonoBehaviour
{
    public void BotonJugar()
    {
        SceneManager.LoadScene(1);
    }
    public void BotonMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }
    public void SalirDelJuego()
    {
        Application.Quit();
    }
}
