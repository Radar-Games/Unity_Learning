using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GibOnCollide : MonoBehaviour 
{
	
	public GameObject explosion;
	public float explosionForce;
	public float spawnRadius;
	public int numGibs;

	private Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter()
	{
		for(int i = 0; i < numGibs; i++)
		{
			GameObject gibInstance = Instantiate(explosion, transform.position + Random.insideUnitSphere * spawnRadius, transform.rotation) as GameObject;
			gibInstance.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, transform.position, spawnRadius);
		}
		Destroy(gameObject);
	}
}
