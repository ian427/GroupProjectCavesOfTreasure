using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveInCave : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float range;
    [SerializeField] float maxDistance;

    Vector2 waypoint;

    //Sets the new destination for the player to move to at the start
    void Start()
    {
        SetNewDestination();
    }

    //If a set destination is met, a new one is selected
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoint, speed * Time.deltaTime);
        if(Vector2.Distance(transform.position, waypoint) < range)
        {
            SetNewDestination();
        }
    }

    //Selects a new destination between a random position between the positions from the maxDistance
    void SetNewDestination()
    {
        waypoint = new Vector2(Random.Range(-maxDistance, maxDistance), Random.Range(-maxDistance, maxDistance));
    }
}
