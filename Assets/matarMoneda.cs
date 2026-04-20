using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matarMoneda : MonoBehaviour
{
    [SerializeField]
    private GameObject obj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
     if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

  }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
    
}

