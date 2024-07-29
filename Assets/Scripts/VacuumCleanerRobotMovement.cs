using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VacuumCleanerRobotMovement : MonoBehaviour
{
    // Array of waypoints
    public Transform[] waypoints;
    // Speed of the robot
    public float speed = 2.0f;
    // Threshold to determine if the robot has reached the waypoint
    public float waypointThreshold = 0.1f;

    // Current waypoint index
    private int currentWaypointIndex = 0;

    void Update()
    {
        if (waypoints.Length == 0)
        {
            return; // No waypoints defined
        }

        // Move towards the current waypoint
        MoveTowardsWaypoint();
    }

    void MoveTowardsWaypoint()
    {
        Transform targetWaypoint = waypoints[currentWaypointIndex];
        Vector3 direction = targetWaypoint.position - transform.position;
        Vector3 movement = direction.normalized * speed * Time.deltaTime;

        // Move the robot
        transform.position += movement;

        // Check if the robot is close enough to the waypoint
        if (direction.magnitude < waypointThreshold)
        {
            // Move to the next waypoint
            Debug.Log($"I am waypoint {currentWaypointIndex}");
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }
    }
}
