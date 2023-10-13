using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject respawnPoint;
	public AudioSource source;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Spike"))
        {
            StartCoroutine(waitThenLoad());
            source.Play();
            gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
            gameObject.GetComponent<LineRenderer>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    private IEnumerator waitThenLoad()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        transform.position = respawnPoint.transform.position;
        gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
        gameObject.GetComponent<LineRenderer>().enabled = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }
}
