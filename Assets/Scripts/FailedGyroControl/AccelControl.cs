using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelControl : MonoBehaviour
{

	//private bool gyroEnabled;
    //private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rot;

    private void Start()
    {
        cameraContainer = new GameObject("Camera Container");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);

        //gyroEnabled = EnableGyro();
    }

    //private bool EnableGyro()
    //{
    //    //Debug.Log(SystemInfo.supportsGyroscope);
    //    //if(SystemInfo.supportsGyroscope)
    //    //{
    //    gyro = Input.gyro;
    //    gyro.enabled = true;
    //    cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
    //    rot = new Quaternion(0, 0, 1, 0); //0010
    //    return true;
    //    //}
    //    //return false;
    //}

    private void Update()
    {
        //gyro orientation is "attitude"
        transform.Rotate(Input.acceleration.y * 0.5f, Input.acceleration.x * 0.5f, 0);
        
    }
}
