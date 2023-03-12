using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Adjust this to change the movement speed

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical input from the keyboard
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Create a new Vector2 with the input values and multiply it by the speed
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * speed;

        // Move the player by adding the movement vector to its position
        transform.position += new Vector3(movement.x, movement.y, 0f);
    }
}