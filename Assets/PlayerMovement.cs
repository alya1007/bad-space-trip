using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;      // The speed at which the player moves.
    public Animator animator;       // Reference to the Animator component.
    private Vector3 direction;      // The direction in which the player should move.
    private bool isMoving = false;  // Indicates whether the player is currently moving.

    private void Update()
    {
        // Get the horizontal and vertical input.
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Set the direction based on the input.
        if (horizontalInput < 0)
        {
            direction = Vector3.left;
        }
        else if (horizontalInput > 0)
        {
            direction = Vector3.right;
        }
        else if (verticalInput > 0)
        {
            direction = Vector3.forward;
        }
        else if (verticalInput < 0)
        {
            direction = Vector3.back;
        }
        else
        {
            direction = Vector3.zero; // If no input is detected, the player stays in the default position.
        }

        // Move the player in the direction specified by the input.
        transform.position += direction * speed * Time.deltaTime;

        // Update the Animator component.
        if (direction != Vector3.zero && !isMoving)
        {
            isMoving = true;
            animator.SetBool("IsMoving", true);
        }
        else if (direction == Vector3.zero && isMoving)
        {
            isMoving = false;
            animator.SetBool("IsMoving", false);
        }
    }
}
