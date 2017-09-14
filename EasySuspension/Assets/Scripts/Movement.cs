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
        leaning = Input.GetAxis("Horizontal") * -0.25f;
        FrontWheel.steerAngle = Input.GetAxis("Horizontal") * turningSpeed;

        //if (Input.GetKeyDown("z") && !Input.GetKeyDown("x")) 
        //{
        //    leaning = -1;
        //    Debug.Log("left");
        //}
        //else if (Input.GetKeyDown("x") && !Input.GetKeyDown("z"))
        //{
        //    leaning = 1;
        //    Debug.Log("right");
        //}
        //else
        //{
        //    leaning = 0;
        //}

        com.x = leaning / 2;

        rb.centerOfMass = com;
    }
}
