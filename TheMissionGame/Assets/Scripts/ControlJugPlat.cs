using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugPlat : MonoBehaviour
{
    private Rigidbody2D rbJugador;
    private Animator animJugador;

    //para caminar
    private bool caminar;
    private float speed = 3.5f;

    //salto
    public LayerMask capaDelPiso;
    public Transform sensorParaPiso;

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
            caminar = true;
            speed = 3.5f;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animJugador.SetBool("esCaminando", false);
            caminar = false;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            animJugador.SetBool("esCaminando", true);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            caminar = true;
            speed = -3.5f;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animJugador.SetBool("esCaminando", false);
            caminar = false;
        }

        if (caminar)
        {
            rbJugador.velocity = new Vector2(speed, rbJugador.velocity.y);
        }
    }
}
