using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detecciondecolisiones : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Mercaderia mercaderiaScript;

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        mercaderiaScript = GetComponent<Mercaderia>();
    }
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Contacto");
        if (col.gameObject.name == "Player")
        {
            Destroy(gameObject);
            scoreManager.AddScore(mercaderiaScript.scorePoints);

        }
      
    }
}