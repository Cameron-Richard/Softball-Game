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

    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("PowerShot"))
		{
            pwr.power = 3f;
            active = true;
            Destroy(other.gameObject);
		}
	}
}