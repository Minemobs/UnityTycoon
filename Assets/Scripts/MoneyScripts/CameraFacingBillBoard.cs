using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFacingBillBoard : MonoBehaviour
{
    void Update()
    {
        Camera cam = Camera.main;
        var camPos = cam.transform.position;
        Vector3 v = camPos - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt( camPos - v ); 
        transform.Rotate(0,0,180);
    }
}
