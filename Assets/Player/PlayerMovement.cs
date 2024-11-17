using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{
    /* Create variables related to Raccoon */
    public float moveSpeed = 5f;
    public Rigidbody rigidBody;
    private Vector3 movement;
    Animator animator;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Move horizontal uses the x-axis, move vertical uses the z-axis
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveZ = Input.GetAxisRaw("Vertical");
        // Movement vector only shifts x and z values, and NOT y
        movement = new Vector3(moveX, 0f, moveZ);
    }

    void FixedUpdate()
    {
        // This line of code allows the player's Rigidbody to move
        rigidBody.MovePosition(rigidBody.position + movement * moveSpeed * Time.fixedDeltaTime);


        /* Flip the Raccoon player based on the horizontal movement direction */
        // If there is movement happening in the x-axis:
        if (movement.x != 0)
        {
            // Flip the Raccoon player if that movement negative in the x-axis
            spriteRenderer.flipX = movement.x < 0;
        }
    }
}