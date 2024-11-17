using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpTrigger : MonoBehaviour
{
    public GameObject popUpCanvas; // Defines what UI window (panel) to display upon trigger
    public float triggerRadius = 1f;  // Sets how close the Raccoon Player needs to be to trigger pop-up
    private Transform playerTransform; // A reference to the Raccoon Player’s transform

    void Start()
    {
        // Search for game object named "Raccoon Player" & get its Transform component
        GameObject player = GameObject.Find("Raccoon Player");
        if (player != null)
        {
            playerTransform = player.transform;
        }
        else
        {
            Debug.LogError("Raccoon Player object not found! Make sure the player object is named 'Raccoon Player'.");
        }
    }

    void Update()
    {
        // Only check distance if the playerTransform has been set
        if (playerTransform != null)
        {
            // Check the distance between the player and the trigger position
            if (Vector3.Distance(playerTransform.position, transform.position) <= triggerRadius)
            {
                ShowPopUp();
            }
            else
            {
                HidePopUp();
            }
        }
    }

    // Display the UI window 
    void ShowPopUp()
    {
        // Enable the attached Panel object to display the UI window
        if (popUpCanvas != null && !popUpCanvas.activeSelf)
        {
            popUpCanvas.SetActive(true);
        }
    }

    // Hide the UI window
    void HidePopUp()
    {
        // Disable the attached Panel object to hide the UI window
        if (popUpCanvas != null && popUpCanvas.activeSelf)
        {
            popUpCanvas.SetActive(false);
        }
    }
}