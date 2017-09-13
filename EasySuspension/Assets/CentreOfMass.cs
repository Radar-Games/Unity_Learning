using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentreOfMass : MonoBehaviour {

	public Vector3 com;
	public Rigidbody rb;

	void Update () {
		rb = GetComponent<Rigidbody> ();
		rb.centerOfMass = com;
	}
}
