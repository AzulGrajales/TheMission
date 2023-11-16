using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalaDerecha : MonoBehaviour
{
    public string Perdiste;

    public int tiempodevida;
    public float velBala;

    void FixedUpdate()
    {
        transform.Translate(Vector2.right * Time.deltaTime * velBala);
    }


    void Update()
    {
        Destroy(this.gameObject, tiempodevida);
    }

}
