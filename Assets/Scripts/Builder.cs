using System.Collections.Generic;
using UnityEngine;

// used for creating shop bullings in the GUI to which call the buildmanager to create the objects.
// used for sending over the premade prefab turret that has been selected to the build manager.
public class Builder : MonoBehaviour {


    public EnemyBlueprint Enemy1; 
    public EnemyBlueprint Enemy2;
    public EnemyBlueprint Enemy3;
    public EnemyBlueprint Enemy4;
    public EnemyBlueprint Enemy5;
    public EnemyBlueprint Enemy6;
    public EnemyBlueprint Enemy7;
    public EnemyBlueprint Enemy8;
    public EnemyBlueprint Enemy9;
    public EnemyBlueprint Enemy10;
    public EnemyBlueprint Enemy11;
    public EnemyBlueprint Enemy12;

    BuildManager buildManger;

    void Start()
    {
        buildManger = BuildManager.instance;
    }

    public void SelectEnemy1()
    {
        Debug.Log("Enemy 1 Selected");
        buildManger.selectEnemyToSpawn(Enemy1); // builds a turret from buildmanager
    }

    public void SelectEnemy2()
    {
        Debug.Log("Enemy 2 Selected");
        buildManger.selectEnemyToSpawn(Enemy2);
    }

    public void SelectEnemy3()
    {
        Debug.Log("Enemy 3 Selected");
        buildManger.selectEnemyToSpawn(Enemy3);
    }

    public void SelectEnemy4()
    {
        Debug.Log("Enemy 4 Selected");
        buildManger.selectEnemyToSpawn(Enemy4);
    }

    public void SelectEnemy5()
    {
        Debug.Log("Enemy 5 Selected");
        buildManger.selectEnemyToSpawn(Enemy5);
    }
}
