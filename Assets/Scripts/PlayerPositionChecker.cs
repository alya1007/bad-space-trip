using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPositionChecker : MonoBehaviour
{
    public string targetTag = "Player";
    public float minX = -9.4f;
    public float maxX = -5.28f;
    public Canvas canvasToToggle;
    public int sceneToLoadIndex = 2;
    private bool isInRange = false;

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
                    SceneManager.LoadScene(sceneToLoadIndex);
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
