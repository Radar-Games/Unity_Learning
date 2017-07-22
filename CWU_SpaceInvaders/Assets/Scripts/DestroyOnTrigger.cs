using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public GameObject explosion;
    public GameObject audio;
    public float explosionForce;
    public float spawnRadius;
    public int numGibs;

    void OnTriggerEnter()
    {
        /*if (other.tag != "Enemy")
        {
            return;
        }*/
        for (int i = 0; i < numGibs; i++)
        {
            GameObject gibInstance = Instantiate(explosion, transform.position + Random.insideUnitSphere * spawnRadius, transform.rotation) as GameObject;
            gibInstance.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, transform.position, spawnRadius);
        }
        Instantiate(audio, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
