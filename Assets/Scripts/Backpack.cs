using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Backpack to store all the pickable items
public class Backpack : MonoBehaviour
{
    public float MaxWeight = 2.0f;

    private float currentWeight = 0;
    private Dictionary<string, int> mapNameToCount = new Dictionary<string, int>();
    private Dictionary<string, GameObject> mapNameToObject = new Dictionary<string, GameObject>();
    
    public bool AddItem(GameObject go)
    {
        var item = go.GetComponent<Item>();
        if(!item)
        {
            // TODO @set reason for rejection
            // GO is not a pickable item
            return false;
        }

        if((item.Data.Weight + currentWeight) <= MaxWeight)
        {
            if(!mapNameToCount.ContainsKey(item.Data.Name))
            {
                mapNameToCount.Add(item.Data.Name, 0);
            }

            mapNameToCount[item.Data.Name]++;
            currentWeight += item.Data.Weight;

            if(!mapNameToObject.ContainsKey(item.Data.Name))
            {
                var tempGO = Instantiate(go) as GameObject;
                tempGO.SetActive(false);
                mapNameToObject.Add(item.Data.name, tempGO);
            }

            return true;
        }
        else
        {
            // TODO @set reason for rejection
            // Backpack is full
            return false;
        }
    }

    public Sprite GetSprite(string name)
    {
        if (mapNameToObject.ContainsKey(name))
            return mapNameToObject[name].GetComponent<Item>().Data.Sprite;

        return null;
    }

    public Dictionary<string, int> GetItems()
    {
        return mapNameToCount;
    }
}
