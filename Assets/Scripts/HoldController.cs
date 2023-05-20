using System.Collections.Generic;
using UnityEngine;

public class HoldController : MonoBehaviour
{
    public Dictionary<KeyCode, string> keyMappings = new Dictionary<KeyCode, string>()
    {
        { KeyCode.D, "shovel" },
        { KeyCode.B, "bucket" },
        { KeyCode.F, "filter" },
        { KeyCode.W, "water bucket" },
        { KeyCode.H, "hemp" },
        { KeyCode.L, "wolfberries" }
    };

    private Dictionary<string, GameObject> holdableItems = new Dictionary<string, GameObject>();

    private void Start()
    {
        foreach (KeyValuePair<KeyCode, string> mapping in keyMappings)
        {
            GameObject item = transform.Find(mapping.Value).gameObject;
            item.SetActive(false);
            holdableItems.Add(mapping.Value, item);
        }

    }

    private void Update()
    {
        foreach (KeyValuePair<KeyCode, string> mapping in keyMappings)
        {
            if (Input.GetKeyDown(mapping.Key))
            {
                EnableItem(mapping.Value);
                break;
            }
        }
    }

    private void EnableItem(string tag)
    {
        DisableAllItems();
        if (holdableItems.TryGetValue(tag, out GameObject item))
        {
            item.SetActive(true);
        }
    }

    private void DisableAllItems()
    {
        foreach (GameObject item in holdableItems.Values)
        {
            item.SetActive(false);
        }
    }
}
