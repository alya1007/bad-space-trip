using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Scriptable Object/Item")]
public class Item : ScriptableObject
{
    public TileBase tile;
    public Sprite image;
    public ItemType type;
    public ActionType actionType;
    public Vector2Int range = new Vector2Int(2, 1);
    public bool stackable = false;


}

public enum ItemType
{
    Tool,
    Resource,
}

public enum ActionType
{
    Dig,
    Plant,
    Water,
    Give,
    Put,
    Chop,
    Filter,
    None,
}
