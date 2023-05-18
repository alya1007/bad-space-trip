using UnityEngine;

public class PersistentObjectManager : MonoBehaviour
{
    public GameObject persistentObject; // Reference to the persistent GameObject

    private void Start()
    {
        if (persistentObject != null)
        {
            // Ensure the persistent object is not destroyed when loading new scenes
            DontDestroyOnLoad(persistentObject);

            // Set the desired position of the persistent object
            persistentObject.transform.position = transform.position;
        }
    }
}
