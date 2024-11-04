using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player's transform
    public float distance = 5f; // Distance from the player
    public float height = 3f; // Height above the player
    public float damping = 2f; // How quickly the camera catches up

    private void LateUpdate()
    {
        // Calculate the desired position
        Vector3 targetPosition = player.position + Vector3.up * height - player.forward * distance;

        // Smoothly move to the target position
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * damping);

        // Make the camera look at the player
        transform.LookAt(player.position);
    }

    private void Update()
    {
        // Rotate the camera based on mouse movement
        if (Input.GetMouseButton(1)) // Right mouse button
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            // Rotate the player based on mouse movement
            player.Rotate(Vector3.up, mouseX);
            Camera.main.transform.RotateAround(player.position, Vector3.up, mouseX);
            Camera.main.transform.RotateAround(player.position, Camera.main.transform.right, -mouseY);
        }
    }
}
