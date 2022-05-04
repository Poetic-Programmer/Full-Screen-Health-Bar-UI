using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float HealthPercentage { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        HealthPercentage = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float amount)
    {
        HealthPercentage -= amount;

        if(HealthPercentage <= 0)
            HealthPercentage = 0;
    }

    public void AddHealth(float amount)
    {
        HealthPercentage += amount;

        if (HealthPercentage >= 100)
            HealthPercentage = 100;
    }
}
