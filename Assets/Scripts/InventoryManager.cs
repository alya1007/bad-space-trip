// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class InventoryManager : MonoBehaviour
// {
//     public InventorySlot[] inventorySlots;
//     public GameObject inventoryItemPrefab;
//     public void AddItem(Item item)
//     {
//         foreach (InventorySlot slot in inventorySlots)
//         {
//             InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
//             if (itemInSlot.itemsCount == 0)
//             {
//                 Destroy(itemInSlot.gameObject); // Delete previous item in the slot
//                 SpawnNewItem(item, slot);
//                 return;
//             }

//         }
//     }

//     public void SpawnNewItem(Item item, InventorySlot slot)
//     {
//         GameObject newItem = Instantiate(inventoryItemPrefab, slot.transform);
//         InventoryItem inventoryItem = newItem.GetComponent<InventoryItem>();
//         inventoryItem.Initialize(item);
//     }

// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public InventorySlot[] inventorySlots;
    public GameObject inventoryItemPrefab;
    public static InventoryManager instance { get; private set; }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }

    }

    public void AddItem(Item item)
    {
        foreach (InventorySlot slot in inventorySlots)
        {
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if (itemInSlot.itemsCount == 0)
            {
                Destroy(itemInSlot.gameObject); // Delete previous item in the slot
                SpawnNewItem(item, slot);
                return;
            }

        }
    }

    public void SpawnNewItem(Item item, InventorySlot slot)
    {
        GameObject newItem = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItem.GetComponent<InventoryItem>();
        inventoryItem.Initialize(item);
    }

}