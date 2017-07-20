using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour 
{
	public float movement;
	
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		Vector3 newVelocity = Vector3.zero;
		newVelocity.y = movement;
		rb.velocity = newVelocity;
	}

	// void Update () {
	// 	Vector3 newPosition = transform.position;
	// 	newPosition.y += movement * Time.deltaTime;
	// 	transform.position = newPosition;
	// }
}
