using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class for all item data
[CreateAssetMenu(fileName = "ItemData", menuName = "Items/ItemData", order = 1)]
public class ItemData : ScriptableObject
{
    public string Name;
    public string Description;
    public float Weight; // in kgs
    public Sprite Sprite;
    public List<string> Actions;
}
