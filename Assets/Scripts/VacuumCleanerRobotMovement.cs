using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VacuumCleanerRobotMovement : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 10f;

    private int currentWaypointIndex = 0;

    private void Start()
    {
        void Start()
        {
            if (waypoints.Length == 0)
            {
                Debug.LogError("No waypoints set for VacuumCleanerRobotMovement.");
            }
        }
    }

    void Update()
    {
        MoveToWaypoints();
    }

    void MoveToWaypoints()
    {
        if (waypoints.Length == 0) return;

        Transform targetWaypoint = waypoints[currentWaypointIndex];

        Vector3 direction = targetWaypoint.position - transform.position;

        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            currentWaypointIndex++;
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
    }
}
