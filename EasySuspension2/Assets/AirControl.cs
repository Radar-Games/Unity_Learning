using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirControl : MonoBehaviour
{
    public float rotationSpeed;

    bool inAir = false;

    void OnTriggerExit(Collider collisionInfo)
    {
        inAir = true;
    }

    void OnTriggerEnter(Collider collisionInfo)
    {
        inAir = false;
    }

    void Update()
    {
        if (inAir)
        {
            transform.Rotate(Input.GetAxis("Vertical") * rotationSpeed, Input.GetAxis("dad") * rotationSpeed, -Input.GetAxis("Horizontal") * rotationSpeed);
        }

        Debug.Log(inAir);
    }
}
