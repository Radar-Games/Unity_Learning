﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	public float movementMultiplier;

	void Update () {
		Vector3 newPosition = transform.position;
        newPosition.x += Input.GetAxis("Horizontal") * movementMultiplier* Time.deltaTime;
		transform.position = newPosition;
	}
}
