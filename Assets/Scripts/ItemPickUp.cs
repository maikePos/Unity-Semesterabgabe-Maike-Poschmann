using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemPickUp 
{
    public enum ItemType
    {
        Key,
        Flowers,
        Vinyl,
        Rune,

    }

    public ItemType itemType;
    public int amount;


}
