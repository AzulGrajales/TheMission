using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalaIzquierda : MonoBehaviour
{
    public string Perdiste;

    public int tiempodevidaizq;
    public float velBalaizq;

    void FixedUpdate()
    {
        transform.Translate(Vector2.left * Time.deltaTime * velBalaizq);
    }


    void Update()
    {
        Destroy(this.gameObject, tiempodevidaizq);
    }

}
