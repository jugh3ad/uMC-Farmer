using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewBlockObject", menuName = "Inventory System/Items/Block")]
public class BlockObject : ItemObject
{
    public int hardness;
    public void Awake()
    {
        itemType = ItemType.Block;
    }
}
