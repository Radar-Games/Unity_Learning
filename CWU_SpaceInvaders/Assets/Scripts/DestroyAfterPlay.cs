using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterPlay : MonoBehaviour
{
    private AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

	void Update()
    {
        if (!audio.isPlaying)
        {
            Destroy(gameObject);
        }
	}
}
