using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    public float speed = 5f;
    public float lifetime = 1f;
    public int direction = 2;
    // 1 = left 2 = right 3 = up 4 = down
    // Start is called before the first frame update
    void Start()
    {
        if(direction == 1)
        {
          Rigidbody2D rb = GetComponent<Rigidbody2D>();
          rb.velocity = -transform.right * speed;
          Destroy(gameObject, lifetime);  
        }
        else if(direction == 2)
        {
          Rigidbody2D rb = GetComponent<Rigidbody2D>();
          rb.velocity = transform.right * speed;
          Destroy(gameObject, lifetime);  
        }
        else if(direction == 3)
        {
          Rigidbody2D rb = GetComponent<Rigidbody2D>();
          rb.velocity = transform.up * speed;
          Destroy(gameObject, lifetime);  
        }
        else if(direction == 4)
        {
          Rigidbody2D rb = GetComponent<Rigidbody2D>();
          rb.velocity = -transform.up * speed;
          Destroy(gameObject, lifetime);  
        }
    }

	void OnCollisionEnter2D(Collision2D other)
	{
		Destroy(gameObject);
	}

}
