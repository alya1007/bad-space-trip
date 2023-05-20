using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this to control the player's movement speed

    public int hpRate = 100;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Get input from horizontal axis (e.g., A and D keys or left and right arrows)

        Vector2 movement = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        // flip when walking right
        if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(2, 2, 2);
        }
        // flip when walking left
        else if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(-2, 2, 2);
        }
        rb.velocity = movement;
    }

    public void decreaseHealth(int damage)
    {
        if (hpRate < 0)
        {
            //Destroy();
        }
        hpRate -= damage;
    }
}