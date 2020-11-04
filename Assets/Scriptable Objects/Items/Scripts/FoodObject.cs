using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewFoodObject", menuName = "Inventory System/Items/Food")]
public class FoodObject : ItemObject
{
    public int healthValue;
    public void Awake()
    {
        itemType = ItemType.Food;
    }
}
