using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    public Item item;
    public Image image;
    public void Initialize(Item newItem)
    {
        image.sprite = newItem.image;
    }
    public void Start()
    {
        Initialize(item);
    }
}
