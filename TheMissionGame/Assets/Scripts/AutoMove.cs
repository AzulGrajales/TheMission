using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    public GameObject objetoMover;
    public float vel;
    public Transform puntoactual;
    public Transform[] puntos;
    public int puntoSeleccionado;


    // Start is called before the first frame update
    void Start()
    {
        puntoactual = puntos[puntoSeleccionado];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        objetoMover.transform.position = Vector3.MoveTowards(
            objetoMover.transform.position,
            puntoactual.position,
            Time.deltaTime * vel);

        if (objetoMover.transform.position == puntoactual.position)
        {
            puntoSeleccionado = 0;
        }

        puntoactual = puntos[puntoSeleccionado];
    }
}
