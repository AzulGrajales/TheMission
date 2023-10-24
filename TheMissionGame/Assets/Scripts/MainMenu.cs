using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void Opciones()
    {
        SceneManager.LoadScene(6);
    }

    public void Creditos()
    {
        SceneManager.LoadScene(7);
    }

    public void Escena1() 
    {

        SceneManager.LoadScene(1);

    }

    public void Escena2() 
    {
        SceneManager.LoadScene(2);
    }

    public void Escena3()
    {
        SceneManager.LoadScene(3);
    }

    public void Ganaste()
    {
        SceneManager.LoadScene(4);
    }

    public void Perdiste()
    {
        SceneManager.LoadScene(5);
    }
        
}
