using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float movementMulitplier;
    public float screenEdgeDisplacement;
    public float dropDistance;

    private int direction = 1;
    
	void Update ()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += movementMulitplier * Time.deltaTime * direction;
        transform.position = newPosition;
        
        if (Camera.main.WorldToScreenPoint(transform.position).x > Screen.width - screenEdgeDisplacement)
        {
            direction = -1;
            
            newPosition.y -= dropDistance;
            transform.position = newPosition;
        }
        else if (Camera.main.WorldToScreenPoint(transform.position).x < 0 + screenEdgeDisplacement)
        {
            direction = 1;

            newPosition.y -= dropDistance;
            transform.position = newPosition;
        }
	}
}
