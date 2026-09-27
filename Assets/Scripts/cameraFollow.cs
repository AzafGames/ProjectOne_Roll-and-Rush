using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject playerObject;
    public Vector3 offset = new Vector3(0, 5, -7);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerObject.transform.position + offset;
    }
}
