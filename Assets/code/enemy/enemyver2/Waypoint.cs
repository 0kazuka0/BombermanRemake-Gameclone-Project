using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Transform[] WayPoints;

    public float Speed = 1f;
    int WaypointIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = WayPoints[WaypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    void move()
    {
        transform.position = Vector2.MoveTowards(transform.position, WayPoints[WaypointIndex].transform.position, Speed * Time.deltaTime);

        if (transform.position == WayPoints[WaypointIndex].transform.position) 
        { 
            WaypointIndex += 1; 
        }
        if(WaypointIndex==WayPoints.Length)
        {
            WaypointIndex = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="bomb")
        {
            WaypointIndex -= 1;
        }
    }
}
