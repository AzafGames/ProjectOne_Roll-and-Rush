
using UnityEngine;
using UnityEngine.UIElements;

// Controls the camera and makes it follow the player
public class cameraFollow : MonoBehaviour
{
    // Stores the player GameObject
    public GameObject playerObject;

    // Sets the camera's position relative to the player
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called once before the first frame
    void Start()
    {
        // Nothing is needed here for now
    }

    // LateUpdate is called after Update
    void LateUpdate()
    {
        // Move the camera to the player's position plus the offset
        transform.position = playerObject.transform.position + offset;
    }
}
