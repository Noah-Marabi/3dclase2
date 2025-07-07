using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int healthPoints;
    public int maxiHealPoints;
    public UIManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = FindObjectOfType<UIManager>();
        healthPoints = maxiHealPoints;
    }

    // Update is called once per frame
    public void TakeDamage(int damagePoints)
    {
        if (healthPoints <=damagePoints)
        {
            return;
        }
        Debug.Log("Damage taken");
        healthPoints -= damagePoints;
        manager.UpdateHealth(healthPoints);
    }
    
}
