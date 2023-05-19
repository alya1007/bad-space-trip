using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    // public CellBase cell;
    public string itemName;
    public ItemType itemType;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(1, 1);
    public bool stackable = true;
    public Sprite icon = null;

    public enum ItemType
    {
        Tool,
        Resource,
    }
    public enum ActionType
    {
        Dig,
        Chop,
        Take,
    }
}
