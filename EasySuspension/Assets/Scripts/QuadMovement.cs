using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadMovement : MonoBehaviour
{
    public WheelCollider FrontLeftWheel;
    public WheelCollider FrontRightWheel;
    public WheelCollider BackLeftWheel;
    public WheelCollider BackRightWheel;
    public Rigidbody rb;
    public float torque;
    public float turningSpeed;

    void Update()
    {
        rb = GetComponent<Rigidbody>();
        
        FrontLeftWheel.steerAngle = Input.GetAxis("Horizontal") * turningSpeed;
        FrontRightWheel.steerAngle = Input.GetAxis("Horizontal") * turningSpeed;

        BackLeftWheel.motorTorque = Input.GetAxis("Vertical") * torque;
        BackRightWheel.motorTorque = Input.GetAxis("Vertical") * torque;
    }
}
