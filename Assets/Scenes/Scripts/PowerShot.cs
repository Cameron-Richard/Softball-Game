using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerShot : MonoBehaviour
{
    public DragNShoot pwr;
    public bool active = false;

    void Start()
    {
        
    }

    void Update()
    {
        if (active == false)
        {
            pwr.power = 1.5f;
        }
    }

    IEnumerator Respawn (Collider2D collision, int time)
    {
        yield return new WaitForSeconds(time);

        collision.gameObject.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("PowerShot"))
		{
            pwr.power = 3.5f;
            active = true;
            collision.gameObject.SetActive(false);
            StartCoroutine(Respawn(collision,4));
		}
	}
}