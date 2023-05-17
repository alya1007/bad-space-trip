using UnityEngine;
using UnityEngine.SceneManagement;

public class BoundaryController : MonoBehaviour
{
    public int nextSceneBuildIndex; // Build index of the next scene

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(nextSceneBuildIndex); // Load the next scene by index
        }
    }
}
