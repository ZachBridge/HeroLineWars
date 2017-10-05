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

    //BuildManager buildManger;

    //void Start()
    //{
    //    buildManger = BuildManager.instance;
    //}

    //public void SelectStandardTurret()
    //{
    //    Debug.Log("Standard Turret Selected");
    //    buildManger.SelectTurretToBuild(standardTurret); // builds a turret from buildmanager
    //}

    //public void SelectMissleLauncher()
    //{
    //    Debug.Log("Missle Turret Selected");
    //    buildManger.SelectTurretToBuild(missleLauncher);
    //}

    //public void SelectLaserBeamer()
    //{
    //    Debug.Log("Laser Beamer Selected");
    //    buildManger.SelectTurretToBuild(laserBeamer);
    //}

    //public void SelectAoeTurret()
    //{
    //    Debug.Log("AOE Turret Selected");
    //    buildManger.SelectTurretToBuild(aoeTurret);
    //}

    //public void SelectMoneyTurret()
    //{
    //    Debug.Log("Money Turret Selected");
    //    buildManger.SelectTurretToBuild(moneyTurret);
    //}
}
