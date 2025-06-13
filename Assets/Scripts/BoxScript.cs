using UnityEngine;

public class BoxScript : MonoBehaviour
{
    Vector3 startPosition;
    Quaternion startRotation; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            transform.position = startPosition;
            transform.rotation = startRotation;
        }
    }
}
