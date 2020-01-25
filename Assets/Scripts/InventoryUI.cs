using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public RectTransform Content;
    public GameObject Item;
    // Backpack
    public Backpack Backpack;

    

    void Start()
    {
    }

    public void Refresh()
    {
        while (Content.childCount > 0)
        {
            var child = Content.GetChild(0);
            child.SetParent(null);
            Destroy(child.gameObject);
        }

        var items = Backpack.GetItems();
        foreach (var item in items)
        {
            var go = Instantiate(Item) as GameObject;
            go.transform.SetParent(Content);
            var itemUI = go.GetComponent<ItemUI>();
            itemUI.Icon.sprite = Backpack.GetSprite(item.Key);
            itemUI.Count.text = "x " + item.Value.ToString();
        }

        // Add new content
    }

    public void Toggle()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
            Refresh();
        }
    }
}
