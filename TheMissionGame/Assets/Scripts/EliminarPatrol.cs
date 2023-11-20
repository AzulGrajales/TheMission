using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarPatrol : MonoBehaviour
{
    public AudioSource PlayMorirEnemigo;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayMorirEnemigo.Play();
            Destroy(transform.parent.parent.gameObject);
        }
    }
}
