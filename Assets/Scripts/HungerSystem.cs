using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerSystem : MonoBehaviour
{
    private int hungerLevel = 0;
    private HealthSystem healthSystem;

    private void Start()
    {
        InvokeRepeating("UpdateHungerLevel", 5.0f, 5.0f);
        healthSystem = GetComponent<HealthSystem>();
    }

    public int GetHungerLevel()
    {
        return hungerLevel;
    }

    public void IncreaseHungerLevel(int factor)
    {
        hungerLevel = Mathf.Clamp(hungerLevel + factor, 0, 100);
    }

    public void DecreaseHungerLevel(int factor)
    {
        hungerLevel = Mathf.Clamp(hungerLevel - factor, 0, 100);
    }

    private void UpdateHungerLevel()
    {
        IncreaseHungerLevel(10);
        if (hungerLevel >= 80)
        {
            healthSystem.DecreaseHealth(10);
        }
    }
}
