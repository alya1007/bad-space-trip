using UnityEngine;
using UnityEngine.SceneManagement;

public class RecipeController : MonoBehaviour
{
    public string targetTag = "Player";
    public float minX = -9.4f;
    public float maxX = -5.28f;
    public Canvas canvasToToggle;
    public GameObject recipe;

    private void Start()
    {
        recipe.SetActive(false);
    }

    private void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag(targetTag);
        if (player != null)
        {
            float playerX = player.transform.position.x;
            if (playerX >= minX && playerX <= maxX)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    recipe.SetActive(!recipe.activeSelf);
                }
                canvasToToggle.gameObject.SetActive(true);
            }
            else
            {
                canvasToToggle.gameObject.SetActive(false);
            }
        }
    }
}
