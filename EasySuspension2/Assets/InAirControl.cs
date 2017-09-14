using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAirControl : MonoBehaviour {

    public Rigidbody rb;
    public float speed;

	void Update ()
    {
        Vector3 com = rb.centerOfMass;

        bool i = false;

        if (Input.GetKey("t") && !Input.GetKey("g"))
        {
            com.z = speed;
            i = true;
        }

        if (Input.GetKey("g") && !Input.GetKey("t"))
        {
            com.z = -speed;
            i = true;
        }

        if (Input.GetKey("f") && !Input.GetKey("h"))
        {
            com.x = -speed;
            i = true;
        }

        if (Input.GetKey("h") && !Input.GetKey("f"))
        {
            com.x = speed;
            i = true;
        }

        if (i == false)
        {
            com.x = 0;
            com.z = 0;
        }
        else
        {
            i = false;
        }

        rb.centerOfMass = com;

        Debug.Log(com);
	}
}
