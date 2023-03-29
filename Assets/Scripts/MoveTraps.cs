using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTraps : MonoBehaviour
{
    [Range(0, 10)]
    public float verticalSpeed;
    [Range(0, 10)]
    public float horizontalSpeed;
    [Range(0, 10)]
    public float amplitude;
    [Range(0, 100)]
    public float rotationSpeed;
    private Vector3 originalPos;
    private Vector3 tempPosition;

    void Start()
    {
        originalPos = transform.position;
        tempPosition = originalPos;
    }

    void FixedUpdate()
    {
        if (horizontalSpeed > 0)
        {
            tempPosition = originalPos;
            tempPosition.x += Mathf.Sin(Time.realtimeSinceStartup * horizontalSpeed) * amplitude;
        }

        else if (verticalSpeed > 0)
        {
            tempPosition = originalPos;
            tempPosition.y += Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude;
        }

        transform.position = tempPosition;
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
