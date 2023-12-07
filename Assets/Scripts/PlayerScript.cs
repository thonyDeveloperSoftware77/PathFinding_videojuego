using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float rotationSpeed = 3.0f;
    public float acceleration = 5.0f;
    public float maxSpeed = 10.0f;

    private void Update()
    {
        // Rotation input
        float rotationInput = Input.GetAxis("Horizontal");
        // Forward and backward input
        float moveInput = Input.GetAxis("Vertical");

        // Rotate the character
        float rotation = rotationInput * rotationSpeed;
        transform.Rotate(0, 0, -rotation);

        // Apply forward or backward movement
        float moveSpeed = moveInput * acceleration;

        // Limit speed to the defined maximum speed
        moveSpeed = Mathf.Clamp(moveSpeed, -maxSpeed, maxSpeed);

        // Calculate movement direction
        Vector3 moveDirection = transform.up * moveSpeed * Time.deltaTime;

        // Move the character in the calculated direction
        transform.Translate(moveDirection, Space.World);
    }
}