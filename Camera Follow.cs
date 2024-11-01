using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour
{
    public Transform target; // The target the camera will follow (e.g., the player)
    public Vector3 offset;   // Offset to adjust the camera's position
    public float smoothSpeed = 0.125f; // Speed of the camera follow

    void LateUpdate()
    {
        // Only track the X and Y axes in a 2D game, keep Z as the original camera position
        Vector3 desiredPosition = new Vector3(target.position.x, target.position.y, transform.position.z) + offset;

        // Smoothly interpolate between the camera's current position and the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Update the camera's position
        transform.position = smoothedPosition;
    }
}
