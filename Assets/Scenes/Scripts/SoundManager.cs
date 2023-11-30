using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip[] sounds;
	private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Coin"))
		{
			source.clip = sounds[Random.Range(0, 2)];
			source.PlayOneShot(source.clip);
		}

		else if (other.gameObject.CompareTag("PowerShot"))
		{
			source.clip = sounds[3];
            source.PlayOneShot(source.clip);
		}
	}
}
