using System.Collections.Generic;
using UnityEngine;

// used for creating shop bullings in the GUI to which call the buildmanager to create the objects.
// used for sending over the premade prefab turret that has been selected to the build manager.
public class Builder : MonoBehaviour {

    public GameObject spawnLocation1;
    public GameObject spawnLocation2;

    public EnemyBlueprint Enemy1; 

    BuildManager buildManger;

    void Start()
    {
        buildManger = BuildManager.instance;
    }

    public void SpawnEnemy1()
    {
        Debug.Log("Enemy 1 Selected");
        GameObject enemySpwaned = (GameObject)Instantiate(Enemy1.prefab, spawnLocation1.transform.position, Quaternion.identity);
        GameObject enemySpwaned2 = (GameObject)Instantiate(Enemy1.prefab, spawnLocation2.transform.position, Quaternion.identity);
    }

}
