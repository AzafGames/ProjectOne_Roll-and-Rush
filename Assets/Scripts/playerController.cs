
using UnityEngine;
using UnityEngine.InputSystem;

// Controls player movement
public class playerController : MonoBehaviour
{
    // Player movement speed
    public float speed = 10.0f;

    // Player jump strength
    public float jumpForce = 10.0f;

    // Movement input
    public InputAction moveInput;

    // Jump input
    public InputAction jumpInput;

    // Stores movement values
    public Vector2 moveAction;

    // Player Rigidbody
    private Rigidbody rb;

    // Checks if player is on ground
    private bool isGrounded = true;

    // Runs at the start
    void Start()
    {
        // Enable movement input
        moveInput.Enable();

        // Enable jump input
        jumpInput.Enable();

        // Get Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    // Runs every frame
    void Update()
    {
        // Read movement input
        moveAction = moveInput.ReadValue<Vector2>();

        // Create movement direction
        Vector3 movement = new Vector3(moveAction.x, 0f, moveAction.y);

        // Move the player
        transform.Translate(movement * speed * Time.deltaTime);

        // Check for jump input
        if (jumpInput.triggered && isGrounded)
        {
            // Apply jump force
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            // Player is now in the air
            isGrounded = false;
        }
    }

    // Runs when player hits something
    private void OnCollisionEnter(Collision collision)
    {
        // Player is on the ground
        isGrounded = true;
    }
}

