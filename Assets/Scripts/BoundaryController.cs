using UnityEngine;
using UnityEngine.SceneManagement;

public class BoundaryController : MonoBehaviour
{
    public int nextSceneBuildIndex; // Build index of the next scene
    public Vector3 playerSpawnPosition; // Coordinates for player spawn position in the next scene

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.sceneLoaded += OnSceneLoaded; // Subscribe to the sceneLoaded event
            SceneManager.LoadScene(nextSceneBuildIndex); // Load the next scene by index
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.buildIndex == nextSceneBuildIndex)
        {
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                player.transform.position = playerSpawnPosition; // Set player position in the next scene
            }
            SceneManager.sceneLoaded -= OnSceneLoaded; // Unsubscribe from the sceneLoaded event
        }
    }
}
