using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public float speed = 10f;
    public InputAction moveInput;
    public Vector2 moveAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        moveAction = moveInput.ReadValue<Vector2>();
        transform.Translate(Vector3.forward * speed * Time.deltaTime * moveAction.y);
        transform.Translate(Vector3.right * speed * Time.deltaTime * moveAction.x);
    }
}
