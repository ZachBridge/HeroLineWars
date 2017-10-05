using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//simple script to whichs just contains a few variables to which are used in other classes (build manager etc)
[System.Serializable]
public class EnemyBlueprint
{
    //Maybe attach a range indicator to a turret blueprint as a seperate object.

    public GameObject prefab;
    public int cost;

    public GameObject upgradedPrefab;
    public int upgradeCost;

}