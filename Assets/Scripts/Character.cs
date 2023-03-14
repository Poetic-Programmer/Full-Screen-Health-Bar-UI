using UnityEngine;

public class Character : MonoBehaviour
{
    public float HealthPercentage { get; private set; }

    void Start()
    {
        HealthPercentage = 100;
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