using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] Character Character = null;
    [SerializeField] HealthUI HealthUI = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            var damage = 10;
            Character.TakeDamage(damage);
            HealthUI.SetHealthFromPercentage(Character.HealthPercentage);
            Debug.Log(string.Format("Taking {0} damage, health at {1}", damage, Character.HealthPercentage));
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            var damage = 10;
            Character.AddHealth(damage);
            HealthUI.SetHealthFromPercentage(Character.HealthPercentage);
            Debug.Log(string.Format("Adding {0} health, health at {1}", damage, Character.HealthPercentage));
        }
    }
}
