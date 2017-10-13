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
    public float range = 15f; //range of how far turrent can attack.


    public GameObject enemy;
    //public GameObject spawn1;

    private void Awake()
    {
        //enemy = GameObject.Find("Enemy1");
        //spawn1 = GameObject.Find("Spawn1");
    }

    void Start()
    {   //Calls the array called points in the Waypoints script and starts the array at 0
        target = Waypoints.points[0];
        //enemy.transform.position = spawn1.transform.position;
    }

    private void Update()
    {   
        // Sets a Vector3 variable to the target position minus the current position
        Vector3 dir = target.position - transform.position;
        // Translates the positon to the new position, basically makes it move
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 1f)
        {
            GetNextWaypoint();
        }


    }

    //void LockOnTarget()
    //{
    //    //target lock-on
    //    Vector3 dir = target.position - transform.position; // figures out distance between target and ourselves
    //    //Quaternion lookRotation = Quaternion.LookRotation(dir); // set its look destination to be the direction to target
    //    //Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles; // converted to eulerangles & we want to smoothly rotate to new target over time.
    //    //partToRotate.rotation = Quaternion.Euler(0f, rotation.y, 0f); // rotate only around the Y axis
    //}

    //void UpdateTarget() // searches for new target/current target
    //{

    //    GameObject[] waypoints = GameObject.FindGameObjectsWithTag("Waypoints"); // array holding all enemies with the tag enemy
    //    float shortestDistance = Mathf.Infinity; // math.infinity used so the distance is infnite while no enemy is found
    //    GameObject nearestEnemy = null;


    //    foreach (GameObject Waypoints in waypoints)
    //    {
    //        float distanceToWaypoint = Vector3.Distance(transform.position, waypoints.transform.position); // get distance from current turret to enemy

    //        if (distanceToWaypoint < shortestDistance) // if distance is shorter then current shortest distance, change the shortest distance to the new one and set this enemy as closest new enemy
    //        {
    //            shortestDistance = distanceToWaypoint;
    //            nearestEnemy = Waypoints;
    //        }
    //    }

    //    if (nearestEnemy != null && shortestDistance <= range) // we have found a enemy and it is within our range.
    //    {
    //        target = nearestEnemy.transform; // sets the target
    //        nearestEnemy = GameObject.FindGameObjectWithTag("Waypoints");
    //        targetEnemy = nearestEnemy;  // sets the nearest enemy to enemy with the tag.
    //    }
    //    else
    //    {
    //        target = null; // if target is no longer in distance change it.
    //    }
    //}




    void GetNextWaypoint()
    {
        if (wavepointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(enemy);
            return;
        }

        wavepointIndex++;
        target = Waypoints.points[wavepointIndex];
    }
   

}
