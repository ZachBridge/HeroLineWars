using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove2 : MonoBehaviour {

    public EnemyMove2 enemyScript;

    public float speed = 50f;

    private Transform target;
    private int wavepointIndex = 0;

    public GameObject enemy;
    public GameObject spawn1;

    private void Awake()
    {
        enemy = GameObject.Find("Enemy1");
        spawn1 = GameObject.Find("Spawn1");
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
