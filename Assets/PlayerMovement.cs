using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;  // Movement speed of the object
    public float maxHeight = 10f;  // Maximum height the object can reach

    private float screenWidth;
    private float screenHeight;

    private void Start()
    {
        // Calculate the screen boundaries in world space coordinates
        float screenAspect = (float)Screen.width / Screen.height;
        float cameraHeight = Camera.main.orthographicSize * 2;
        screenWidth = screenAspect * cameraHeight;
        screenHeight = cameraHeight;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}
