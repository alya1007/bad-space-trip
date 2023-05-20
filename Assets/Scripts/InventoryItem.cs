using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    public Item item;
    public Image image;
    public int itemsCount = 0;
    public void Initialize(Item newItem)
    {
        image.sprite = newItem.image;
        itemsCount = 1;
    }
    public void Start()
    {
        Initialize(item);
    }
}
