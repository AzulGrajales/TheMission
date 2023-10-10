using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform jugador;

    void Update()
    {
        transform.position =  new Vector3(jugador.position.x, jugador.position.y, transform.position.z);
    }
}
