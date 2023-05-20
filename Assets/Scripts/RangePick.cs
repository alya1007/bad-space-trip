// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class RangePick : MonoBehaviour
// {
//     public string targetTag = "Player";
//     public float minX = -9.4f;
//     public float maxX = -5.28f;
//     public Canvas canvasToToggle;
//     private bool isInRange = false;
//     public InventoryManager inventoryManager;
//     public Item itemToPick;
//     public GameObject objectToAdd;

//     private void Update()
//     {
//         GameObject player = GameObject.FindGameObjectWithTag(targetTag);
//         if (player != null)
//         {
//             float playerX = player.transform.position.x;
//             if (playerX >= minX && playerX <= maxX)
//             {
//                 isInRange = true;
//                 if (Input.GetKeyDown(KeyCode.E))
//                 {
//                     inventoryManager.AddItem(itemToPick);
//                     Destroy(objectToAdd);
//                     Destroy(canvasToToggle.gameObject);
//                     return;
//                 }
//                 canvasToToggle.gameObject.SetActive(true);
//             }
//             else
//             {
//                 isInRange = false;
//                 canvasToToggle.gameObject.SetActive(false);
//             }
//         }
//     }
// }

using UnityEngine;
using UnityEngine.SceneManagement;

public class RangePick : MonoBehaviour
{
    public string targetTag = "Player";
    public float minX = -9.4f;
    public float maxX = -5.28f;
    public Canvas canvasToToggle;
    private bool isInRange = false;
    // public InventoryManager inventoryManager;
    public Item itemToPick;
    public GameObject objectToAdd;

    private void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag(targetTag);
        if (player != null)
        {
            float playerX = player.transform.position.x;
            if (playerX >= minX && playerX <= maxX)
            {
                isInRange = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    InventoryManager.instance.AddItem(itemToPick);
                    Destroy(objectToAdd);
                    Destroy(canvasToToggle.gameObject);
                    return;
                }
                canvasToToggle.gameObject.SetActive(true);
            }
            else
            {
                isInRange = false;
                canvasToToggle.gameObject.SetActive(false);
            }
        }
    }
}
