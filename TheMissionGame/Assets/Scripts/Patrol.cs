using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public GameObject objetoMover;
    public float vel;
    public Transform puntoactual;
    public Transform[] puntos;
    public int puntoSeleccionada;


    void Start()
    {
        puntoactual = puntos[puntoSeleccionada];
    }

    private void FixedUpdate()
    {
        objetoMover.transform.position = Vector3.MoveTowards( objetoMover.transform.position, puntoactual.position, Time.deltaTime * vel);

        if (objetoMover.transform.position == puntoactual.position)
        {
            puntoSeleccionada += 1;
            if (puntoSeleccionada == puntos.Length)
            {
                puntoSeleccionada = 0;
            }
        }

        puntoactual = puntos[puntoSeleccionada];
    }

    void Update()
    {
        if (puntoSeleccionada == 0)
        {
            objetoMover.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (puntoSeleccionada == 1)
        {
            objetoMover.transform.localRotation = Quaternion.Euler(0, 180f, 0);
        }
    }
}
