
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove2 : MonoBehaviour {

    public EnemyMove2 enemyScript;

    public float speed = 50f;

    //private Transform target;
    private int wavepointIndex = 0;

    private Transform target; // used for storing current target 

    private Enemy targetEnemy;
    public float range = 50f; //range of how far turrent can attack.


    void Start()
    {   
        InvokeRepeating("UpdateTarget", 0f, 0.5f); // instantly search for a target, then checky every 0.5seconds
    }

    private void Update()
    {   
        
    }

    void UpdateTarget() // searches for new target/current target
    {

        GameObject[] waypoints = GameObject.FindGameObjectsWithTag("Waypoint"); //Stores all objects with the tag (Waypoints) in here
        float shortestDistance = Mathf.Infinity; // math.infinity used so the distance is infnite while no enemy is found
        GameObject nearestWaypoint = null;


        //foreach (GameObject Waypoints in waypoints)
        //{
        //    float distanceToWaypoint = Vector3.Distance(transform.position, waypoints.transform.position); // get distance from current turret to enemy

        //    if (distanceToWaypoint < shortestDistance) // if distance is shorter then current shortest distance, change the shortest distance to the new one and set this enemy as closest new enemy
        //    {
        //        shortestDistance = distanceToWaypoint;
        //        nearestWaypoint = Waypoints;
        //    }
        //}

        //if (nearestWaypoint != null && shortestDistance <= range) // we have found a enemy and it is within our range.
        //{
        //    target = nearestWaypoint.transform; // sets the target
        //    nearestWaypoint = GameObject.FindGameObjectWithTag("Waypoints");
        //    targetEnemy = nearestWaypoint;  // sets the nearest enemy to enemy with the tag.
        //}
        //else
        //{
        //    target = null; // if target is no longer in distance change it.
        //}
    }

    void LockOnTarget()
    {
        //target lock-on
        Vector3 dir = target.position - transform.position; // figures out distance between target and ourselves
        //Quaternion lookRotation = Quaternion.LookRotation(dir); // set its look destination to be the direction to target
        //Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles; // converted to eulerangles & we want to smoothly rotate to new target over time.
        //partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f); // rotate only around the Y axis
    }

    

   }
