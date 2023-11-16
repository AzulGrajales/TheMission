using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirEnemigo1 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        public AudioSource

        if (collision.gameObject.tag == "Player")
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
