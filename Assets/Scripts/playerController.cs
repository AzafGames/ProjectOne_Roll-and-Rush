
using UnityEngine;
using UnityEngine.InputSystem;

// Controls the player's movement
public class playerController : MonoBehaviour
{
    // Controls how fast the player moves
    public float speed = 10f;

    // Stores the player's movement input
    public InputAction moveInput;

    // Stores the X and Y movement values
    public Vector2 moveAction;

    // Start is called once before the first frame
    void Start()
    {
        // Enable the movement input
        moveInput.Enable();
    }

    // Update is called once every frame
    void Update()
    {
        // Read the movement input from the player
        moveAction = moveInput.ReadValue<Vector2>();

        // Create the movement direction
        Vector3 movement = new Vector3(moveAction.x, 0f, moveAction.y);

        // Move the player
        transform.Translate(movement * speed * Time.deltaTime);
    }
}

