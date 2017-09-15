using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InAirControl : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
	public float speed2;
	public float multi;
	public Transform t;

    public bool Assistance;

	void Update ()
    {
        Vector3 com = rb.centerOfMass;
        Vector3 newCom = new Vector3();
        float rotationz = t.rotation.z * 30;
        float rotationx = t.rotation.x * 30;

        if (Assistance)
        {
            if (rotationz > 3)
            {
                newCom.z += speed2 * (rotationz * multi);
            }

            if (rotationz < -3)
            {
                newCom.z += -speed2 * (rotationz * multi);
            }

            if (rotationx > 3)
            {
                newCom.x += -speed2 * (rotationx * multi);
            }

            if (rotationx < -3)
            {
                newCom.x += speed2 * (rotationx * multi);
            }
        }

        bool i = false;

        if (Input.GetKey("t") && !Input.GetKey("g"))
        {
            newCom.x = speed;
            i = true;
        }

        if (Input.GetKey("g") && !Input.GetKey("t"))
        {
            newCom.x = -speed;
            i = true;
        }

        if (Input.GetKey("f") && !Input.GetKey("h"))
        {
            newCom.z = speed;
            i = true;
        }

        if (Input.GetKey("h") && !Input.GetKey("f"))
        {
            newCom.z = -speed;
            i = true;
        }

        //if (i == false)
        //{
        //    newCom.x = 0;
        //    newCom.z = 0;
        //}
        //else
        //{
        //    i = false;
        //}

        com += newCom;

        rb.AddTorque(com);

        Debug.Log(rotationx);

        //Debug.Log(com);
	}
}
