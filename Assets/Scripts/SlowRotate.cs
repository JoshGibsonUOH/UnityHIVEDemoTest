using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowRotate : MonoBehaviour
{
    public float rotateSpeedX = 10f;
    public float rotateSpeedY = 10f;
    public float rotateSpeedZ = 10f;

    void Update()
    {
        // Rotate the object around its local X, Y, and Z axes
        transform.Rotate(rotateSpeedX * Time.deltaTime, rotateSpeedY * Time.deltaTime, rotateSpeedZ * Time.deltaTime);
    }
}

