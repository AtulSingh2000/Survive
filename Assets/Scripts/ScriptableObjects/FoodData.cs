using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FoodData", menuName = "Items/FoodData", order = 1)]
public class FoodData : ItemData
{
    public int hunger = 100;
    public int health = 10;
}
