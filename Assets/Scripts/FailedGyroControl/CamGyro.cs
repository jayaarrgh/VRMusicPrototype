using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamGyro : MonoBehaviour {
    //attach this class to main camera
    GameObject camParent;

	// Use this for initialization
	void Start () {
        camParent = new GameObject("CamParent");
        camParent.transform.position = this.transform.position;
        this.transform.parent = camParent.transform;
        Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        camParent.transform.Rotate (0, -Input.gyro.attitude.y, 0);
        this.transform.Rotate (-Input.gyro.attitude.x, 0, 0);
	}
}
