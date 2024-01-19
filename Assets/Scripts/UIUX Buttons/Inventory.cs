using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<ItemPickUp> itemList;

    public Inventory()
    {
        itemList = new List<ItemPickUp>();

        AddItem(new ItemPickUp { itemType = ItemPickUp.ItemType.Flowers, amount = 1 });
        AddItem(new ItemPickUp { itemType = ItemPickUp.ItemType.Key, amount = 1 });
        AddItem(new ItemPickUp { itemType = ItemPickUp.ItemType.Vinyl, amount = 1 });
        AddItem(new ItemPickUp { itemType = ItemPickUp.ItemType.Rune, amount = 1 });

        Debug.Log(itemList.Count);
    }

    public void AddItem (ItemPickUp item)
    {
        itemList.Add(item);
    }

    public List<ItemPickUp> GetItemList()
    {
        return itemList;
    }
}
