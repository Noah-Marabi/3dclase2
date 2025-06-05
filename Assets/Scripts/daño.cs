using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daño : MonoBehaviour
{
    public HealthManager healthManager;
    void OnCollisionEner(Collision col)
    {
        Debug.Log("Contacto");
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            healthManager.TakeDamage(10);
        }
    }
}