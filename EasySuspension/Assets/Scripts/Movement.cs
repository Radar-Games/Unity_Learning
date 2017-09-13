using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public WheelCollider FrontWheel;
    public WheelCollider BackWheel;
    public float torque;
    public float turningSpeed;
    public Vector3 com;
    public Rigidbody rb;
    private float leaning;
    
    void Update ()
    {
        rb = GetComponent<Rigidbody>();

        BackWheel.motorTorque = Input.GetAxis("Vertical") * torque;
        FrontWheel.steerAngle = Input.GetAxis("Horizontal") * turningSpeed;

        if(rb.rotation.z < 10)
        {
            com.x = -0.05f;
        }
        else if (rb.rotation.z > 10)
        {
            com.x = 0.05f;
        }
        else
        {
            com.x = 0;
        }

        rb.centerOfMass = com;
    }
}
