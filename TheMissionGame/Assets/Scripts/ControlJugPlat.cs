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
    public float fuerzaDelSalto;
    private bool estaEnelpiso;
    private float radioDelSensor = 0.07f;

    // Start is called before the first frame update
    void Start()
    {
        rbJugador = GetComponent<Rigidbody2D>();
        animJugador = GetComponent<Animator>();
    }

    //Metodo Fixedupdate para detectar cuando el jugador esta en el piso
    private void FixedUpdate()
    {
        estaEnelpiso = Physics2D.OverlapCircle(sensorParaPiso.position, radioDelSensor, capaDelPiso);
        animJugador.SetBool("esSaltando", !estaEnelpiso);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.D))
        {
            animJugador.SetBool("esCaminando", true);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
            caminar = true;
            speed = 7.0f;
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
            speed = -7.0f;
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

        //para saltar
        if (estaEnelpiso)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                rbJugador.AddForce(new Vector2(0, fuerzaDelSalto));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "PlatMover")
        {
            transform.parent = collision.transform;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "PlatMover")
        {
            transform.parent = null;
        }
    }
}
