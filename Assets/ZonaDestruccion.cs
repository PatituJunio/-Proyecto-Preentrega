using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaDestruccion : MonoBehaviour
{
    // si algun objeto toca el cuadrado rojo debe destruirse
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
