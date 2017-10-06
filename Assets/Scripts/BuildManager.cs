using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script is used for checking if a player is able to build in a location and if they have the money required for the correct object to buold there.
public class BuildManager : MonoBehaviour {

    public static BuildManager instance; // used for storing a refernce to itself


    private EnemyBlueprint enemyToSpawn; // variable that stores what turret will be set.



    public bool canSpawn { get { return enemyToSpawn != null; } } // variable can never be set, if turret to build returns not equal to null it'll return true, else it'll return false
    // public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } } // if we have enough money, return true.
    


    public void selectEnemyToSpawn(EnemyBlueprint enemy) //used for selecting turrets to build
    {
        enemyToSpawn = enemy;
    }

    // simple method to which calles the not enough money fader in the nodeUI allowing it show a visual representive of not having enough money
    public void notEnoughMoney()
    {

    }

    public EnemyBlueprint GetTurretToBuild()
    {
        return enemyToSpawn;
    }


}
