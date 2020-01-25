using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private int health = 100;

    public int GetHealth()
    {
        return health;
    }

    public void IncreaseHealth(int factor)
    {
        health = Mathf.Clamp(health+factor,0,100);
    }

    public void DecreaseHealth(int factor)
    {
        health = Mathf.Clamp(health - factor, 0, 100);
    }
}
