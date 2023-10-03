using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugPlat : MonoBehaviour
{
    private Rigidbody2D rbJugador;
    private Animator animJugador;

    // Start is called before the first frame update
    void Start()
    {
        rbJugador = GetComponent<Rigidbody2D>();
        animJugador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.D))
        {
            animJugador.SetBool("esCaminando", true);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animJugador.SetBool("esCaminando", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animJugador.SetBool("esCaminando", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animJugador.SetBool("esCaminando", false);
        }
    }
}
