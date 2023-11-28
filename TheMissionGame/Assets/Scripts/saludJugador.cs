using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class saludJugador : MonoBehaviour
{
    public int MaximaSalud2 = 10;
    public int ActualSalud2;
    public parentSalud barraDeSalud2;

    void Start()
    {
        ActualSalud2 = MaximaSalud2;
        barraDeSalud2.AsignarSaludMaxima2(MaximaSalud2);
    }

   private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.tag == "enemigo0" )
        {
            BajarSalud2(1);
        }
        if (collision.gameObject.tag == "enemigo1")
        {
            BajarSalud2(2);
        }
        if (collision.gameObject.tag == "enemigo2")
        {
            BajarSalud2(5);
        }
        if (collision.gameObject.tag == "enemigo3")
        {
            BajarSalud2(10);
        }

        void BajarSalud2 (int cuantoBajar)
        {
            ActualSalud2 -= cuantoBajar;
            barraDeSalud2.AsignarSalud2(ActualSalud2);
            if (ActualSalud2 <= 0) 
            {
                SceneManager.LoadScene(4);
            }
        }
    }
}
