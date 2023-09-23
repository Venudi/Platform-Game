using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    // get waypoints
    [SerializeField] private GameObject[] waypoints;
    // current waypoint index
    private int currentWaypointIndex = 0;
    // speed
    [SerializeField] private float speed = 2f;

    private void Update()
    {
        // if waypoints is not empty
        if (waypoints.Length > 0)
        {
            // get current waypoint
            GameObject currentWaypoint = waypoints[currentWaypointIndex];
            // move to current waypoint
            transform.position = Vector2.MoveTowards(transform.position, currentWaypoint.transform.position, speed * Time.deltaTime);
            // if current waypoint is reached
            if (transform.position == currentWaypoint.transform.position)
            {
                // flip
                transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
                // increase current waypoint index
                currentWaypointIndex++;
                // if current waypoint index is equal to waypoints length
                if (currentWaypointIndex == waypoints.Length)
                {
                    // reset current waypoint index
                    currentWaypointIndex = 0;
                }
            }
        }   
    }
}
