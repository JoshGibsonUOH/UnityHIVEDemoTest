using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Transform character; // Reference to the character
    public float distanceInFront = 2f; // Distance in front of the character
    public float movementSpeed = 1f; // Speed at which object moves
    public float pauseDuration = 2f; // Duration to pause at each end

    private Vector3 originalPosition;
    private Vector3 targetPosition;
    private bool movingTowardsPlayer = true;
    private float pauseTimer;

    void Start()
    {
        // Save the original position
        originalPosition = transform.position;
        // Calculate the target position in front of the character
        targetPosition = character.position + character.forward * distanceInFront;
    }

    void Update()
    {
        MoveObjectBackAndForth();
    }

    private void MoveObjectBackAndForth()
    {
        if (pauseTimer > 0)
        {
            pauseTimer -= Time.deltaTime;
            return;
        }

        Vector3 target = movingTowardsPlayer ? targetPosition : originalPosition;
        transform.position = Vector3.MoveTowards(transform.position, target, movementSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) < 0.01f) // Object has reached the target
        {
            movingTowardsPlayer = !movingTowardsPlayer; // Change direction
            pauseTimer = pauseDuration; // Start pause
        }
    }
}



