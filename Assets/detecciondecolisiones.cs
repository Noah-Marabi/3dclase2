using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detecciondecolisiones : MonoBehaviour
{
    void OnCollisionEnter()
    {
        Debug.Log("Contacto");
        Destroy(gameObject);
    }
}