using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement2 : MonoBehaviour
{
    public float speed = 0.2f; // Car speed
    public float distance = 0.7f; // How far the car will travel forward/backward

    private Vector3 startPosition; // Car starting position
    private bool movingForward = true; // To track the current movement direction

    void Start()
    {
        // Save the car's initial position
        startPosition = transform.position;
    }

    void Update()
    {
        // Calculate the movement direction (x-z plane only) - going from right to left
        Vector3 direction = movingForward ? new Vector3(-1, 0, -0.6f) : new Vector3(1, 0, 0.6f);

        // Move the car along the x-axis & z-axis to give off the illusion that its moving flatly on the map:
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        // Check if the car has reached the distance limit
        if (Vector3.Distance(startPosition, transform.position) >= distance)
        {
            // Reverse direction and update startPosition
            movingForward = !movingForward;
            startPosition = transform.position;
        }
    }
}