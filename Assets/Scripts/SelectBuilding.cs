using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBuilding : MonoBehaviour {

    private Renderer rend;

    public GameObject enemy;
    public GameObject spawnpoint;

    public bool isHit = false;

    private void Awake()
    {
        //mat = Resources.Load("mobspawnermat", typeof(Material)) as Material;
        rend = GetComponent<Renderer>();
        enemy = GameObject.Find("Enemy1");
        spawnpoint = GameObject.Find("Spawn1");
    }

    void Update()
    {
        BuildingSelected();
        SpawnMob();

    }

    void BuildingSelected()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse is down");

            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

            if (hit)
            {
                Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                if (hitInfo.transform.gameObject.tag == "MobSpawner")
                {
                    Debug.Log("It's working!");
                    isHit = true;
                }
                else
                {
                    Debug.Log("nopz");
                }
            }
            else
            {
                Debug.Log("No hit");
            }
            Debug.Log("Mouse is down");
        }
    }


    void SetColor()
    {
        rend.material.SetColor("mobspawnermat", Color.red);
    }

    void SpawnMob()
    {
        if (isHit == true)
        {
            GameObject obj = Instantiate(enemy, spawnpoint.transform) as GameObject;
        }
    }
}


