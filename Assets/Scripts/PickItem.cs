using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickItem : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itemToPick;

    public void PickUpItem(int id)
    {
        inventoryManager.AddItem(itemToPick[id]);
    }
}
