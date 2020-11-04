using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NewToolObject", menuName = "Inventory System/Items/Tool")]
public class ToolObject : ItemObject
{
    public int durability;
    public ToolType toolType;
    public ToolMaterial toolMaterial;

    public void Awake()
    {
        itemType = ItemType.Tool;

        switch (toolMaterial)
        {
            case ToolMaterial.Wood:
                durability = 59;
                break;
            case ToolMaterial.Stone:
                durability = 131;
                break;
            case ToolMaterial.Iron:
                durability = 250;
                break;
            case ToolMaterial.Gold:
                durability = 32;
                break;
            case ToolMaterial.Diamond:
                durability = 1561;
                break;
            case ToolMaterial.Netherite:
                durability = 2031;
                break;
            default:
                break;
        }


    }
}

public enum ToolType
{
    Hoe,
    Shovel,
    Axe,
    Pickaxe
}

public enum ToolMaterial
{
    Wood,
    Stone,
    Iron,
    Gold,
    Diamond,
    Netherite
}
