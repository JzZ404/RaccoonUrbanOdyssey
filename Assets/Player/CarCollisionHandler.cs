using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollisionHandler : MonoBehaviour
{
    // Reference to the UI panel
    public GameObject collisionPanel;

    private void Start()
    {
        // Ensure the panel is inactive at the start
        collisionPanel.SetActive(false);
    }

    // Collision detection method for 3D collisions
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is the "car"
        if (collision.gameObject.CompareTag("Car"))
        {
            // Activate the UI panel
            collisionPanel.SetActive(true);
        }
        else
        {
            // Disable the UI panel
            collisionPanel.SetActive(false);
        }
    }
}