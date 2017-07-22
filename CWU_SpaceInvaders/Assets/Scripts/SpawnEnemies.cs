using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

    public GameObject spawnedObject;
    public float spawnWidth;
    public float spawnHeight;
    public int numberEnemiesX;
    public int numberEnemiesY;

	void Start () {
		for(int i = 0; i < numberEnemiesX; i++)
        {
            for(int j = 0; j < numberEnemiesY; j++)
            {
                Vector3 spawnPosition = transform.position;
                spawnPosition.x += i * (spawnWidth / numberEnemiesX);
                spawnPosition.y += j * (spawnHeight / numberEnemiesY);
                GameObject newObject = Instantiate(spawnedObject, spawnPosition, spawnedObject.transform.rotation) as GameObject;
                newObject.transform.parent = gameObject.transform;
            }
        }
	}

    void Update()
    {
        if(transform.childCount == 0)
        {
            Start();
        }
    }

    void OnDrawGizmos()
    {
        for(int i = 0; i < numberEnemiesX; i++)
        {
            for(int j = 0; j < numberEnemiesY; j++)
            {
                Vector3 spawnPosition = transform.position;
                spawnPosition.x += i * (spawnWidth / numberEnemiesX);
                spawnPosition.y += j * (spawnHeight / numberEnemiesY);
                Gizmos.DrawLine(spawnPosition + Vector3.left, spawnPosition + Vector3.right);
                Gizmos.DrawLine(spawnPosition + Vector3.up, spawnPosition + Vector3.down);
                Gizmos.DrawLine(spawnPosition + Vector3.forward, spawnPosition + Vector3.back);
            }
        }
    }
}
