using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public WheelCollider FrontWheel;
	public WheelCollider BackWheel;
	public Rigidbody rb;
    public float torque;
    public float turningSpeed;
    public Vector3 com;
    private float leaning;

    void FixedUpdate()
    {
        leaning = 0;
    }

    void Update ()
    {
        rb = GetComponent<Rigidbody>();

        BackWheel.motorTorque = Input.GetAxis("Vertical") * torque;
        FrontWheel.steerAngle = Input.GetAxis("Horizontal") * turningSpeed;

        if (Input.GetKey("z") && !Input.GetKey("x")) 
        {
            leaning = -0.25f;
            Debug.Log("left");
        }
        else if (Input.GetKey("x") && !Input.GetKey("z"))
        {
            leaning = 0.25f;
            Debug.Log("right");
        }
        else
        {
            leaning = 0;
        }

        com.x = leaning;

        rb.centerOfMass = com;
    }
}
