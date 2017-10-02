using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class EnemyMove : MonoBehaviour {

    private Vector3 targetPosition;

    public GameObject spawn1;
    public GameObject enemy1;
    public GameObject portal1;

    UnityEngine.AI.NavMeshAgent agent2;


    // Cache all components
    private void Awake()
    {
        agent2 = GetComponent<UnityEngine.AI.NavMeshAgent>();
        spawn1 = GameObject.Find("Spawn1");
        enemy1 = GameObject.Find("Enemy1");
        portal1 = GameObject.Find("Portal1");
    }

    // Use this for initialization
    void Start () {
        enemy1.transform.position = spawn1.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        SetTargetPosition();

        MoveEnemy();

	}

    void SetTargetPosition()
    {   //Instantiates a new instance of a plane on the y axis of the current position of the object
        Plane plane = new Plane(Vector3.up, transform.position);
        //Instantiates a new instance of a raycast that points from the center of the camera to the current mouse position
        Ray ray = Camera.main.ScreenPointToRay(portal1.transform.position);
        float point = 0f;

        if (plane.Raycast(ray, out point))
            targetPosition = ray.GetPoint(point);
    }

    void MoveEnemy()
    {
        agent2.SetDestination(targetPosition);

        Debug.DrawLine(transform.position, targetPosition, Color.red);
    }


}
