using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Variables to control the player's movement speed and the animator component
    public float moveSpeed = 5f;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical input from the keyboard
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calculate the movement vector based on the input and speed
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;

        // Log the movement vector for debugging purposes
        Debug.Log("Movement Vector: " + movement);

        // Update the player's position based on the movement vector
        transform.position += movement;

        // Check if the player is moving
        if (movement.magnitude > 0f)
        {
            // Set the animation parameters based on the input direction
            animator.SetFloat("Horizontal", horizontalInput);
            animator.SetFloat("Vertical", verticalInput);
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }
}