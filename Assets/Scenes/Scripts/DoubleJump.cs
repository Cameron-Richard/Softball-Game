using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJump : MonoBehaviour
{
    public bool activeDJ = false;

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Respawn (Collider2D collision, int time)
    {
        yield return new WaitForSeconds(time);

        collision.gameObject.SetActive(true);
    }

    void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("DoubleJump"))
		{
            activeDJ = true;
            collision.gameObject.SetActive(false);
            StartCoroutine(Respawn(collision,4));
		}
	}
}
