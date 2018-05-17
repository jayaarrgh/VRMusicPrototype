using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This is a phone gyro looker...
// add listener on ball in front of cameras orientation (spherecast? look at  )
// I would then have the "Look Listener"
// Which i like the idea of doing... that would be fun.
public class GyroControl : MonoBehaviour
{
	private bool gyroEnabled;
    private Gyroscope gyro;

    private GameObject cameraContainer;
    private Quaternion rot;

    private void Start()
    {
        cameraContainer = new GameObject("Camera Container");
        cameraContainer.transform.position = transform.position;
        transform.SetParent(cameraContainer.transform);

        gyroEnabled = EnableGyro();
    }

    private bool EnableGyro()
    {
        //Debug.Log(SystemInfo.supportsGyroscope);
        //if(SystemInfo.supportsGyroscope)
        //{
            gyro = Input.gyro;
            gyro.enabled = true;
            cameraContainer.transform.rotation = Quaternion.Euler(90f, 90f, 0f);
            rot = new Quaternion(0,0,1,0); //0010
            return true;
        //}
        //return false;
    }

    private void Update() 
    {
        if(gyroEnabled)
        {
            //gyro orientation is "attitude"
            transform.localRotation = gyro.attitude * rot;
        }
    }
}