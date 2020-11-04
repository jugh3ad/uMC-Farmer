﻿using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
[CreateAssetMenu(fileName = "NewInventoryObject", menuName = "Inventory System/Inventory")]

public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> Container = new List<InventorySlot>();

    public void AddItem(ItemObject _item, int _amount)
    {
        for (int i = 0; i < Container.Count; i++)
        {
            if(Container[i].item == _item)
            {
                Container[i].AddAmount(_amount);
                continue;
            }
        }
        Container.Add(new InventorySlot(_item, _amount));
    }
}
[System.Serializable]
public class InventorySlot
{
    public ItemObject item;
    public int amount;

    public InventorySlot(ItemObject _item, int _amount)
    {
        item = _item;
        amount = _amount;
    }

    public void AddAmount(int value)
    {
        amount += value;
    }
}
