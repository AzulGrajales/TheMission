using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner1 : MonoBehaviour
{
    public Vector2 nuevaPos;
    public GameObject PicoCaer;
    public float intervaloParaCrear;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= intervaloParaCrear)
        {
            GameObject nuevoObjeto = Instantiate(PicoCaer);
            Vector2 posFinal = nuevaPos;
            posFinal = (Vector2)transform.position + nuevaPos;
            nuevoObjeto.transform.position = posFinal;
            timer -= intervaloParaCrear;
        }
    }
}
