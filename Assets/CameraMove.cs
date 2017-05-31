using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public LayerMask groundlayer;

    [System.Serializable]
    public class PositionSettings
    {
        public bool invertPan = true;
        public float panSmooth = 7;
        public float distanceFromGround = 40;
        public bool allowZoom = true;
        public float zoomSmooth = 5;
        public float zoomStep = 5;
        public float maxZoom = 25;
        public float minZoom = 80;

        [HideInInspector]
        public float newDistance = 40;

        

    }

    [System.Serializable]
    public class OrbitSettings
    {
        public float xRotation = 50;
        public float yRotation = 0;
        public bool allowYOrbit = true;
        public float yOrbitSmooth = 0.5f;

    }

    [System.Serializable]
    public class InputSettings
    {
        public string PAN = "MousePan";
        public string ORBIT_Y = "MouseTurn";
        public string ZOOM = "Mouse ScrollWheel";

    }

    public PositionSettings position = new PositionSettings;
    public OrbitSettings orbit = new OrbitSettings;
    public InputSettings input = new InputSettings;

    Vector3 destination = Vector3.zero;
    Vector3 camVel = Vector3.zero;
    Vector3 previousMousePos = Vector3.zero;
    Vector3 currentMousePos = Vector3.zero;
    float panInput, orbitInput, zoomInput;
    int panDirection = 0;

    void Start()
    {
        // initialisation code 

    }


    void getInput()
    {
        // responsible  for setting our input variables 
    }

    void Update()
    {
        //upodating input, zooming, rotating, panning 

    }

    void FixedUpdate()
    {
        // handle camera distance -- raycasting goes in fixed update 

    }

    void PanWorld()
    {


    }

    void handleCameraDistance()
    {


    }

    void Zoom()
    {


    }

    void Rotate()
    {


    }





}
