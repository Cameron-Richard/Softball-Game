using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public GameObject DeathEffect;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Spike"))
        {
            DeathEffect.gameObject.GetComponent<ParticleSystem>().Play();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("HomePlate"))
        {
            GetComponent<ParticleSystem>().Play();
            Debug.Log("Steven Aguiar");
        }
    }
}
