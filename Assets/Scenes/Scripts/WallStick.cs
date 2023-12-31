using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallStick : MonoBehaviour
{
	public float rotationSpeed = 500f;
    public Rigidbody2D rb;
    public bool canRotate = false;

	public CoinManager cm;
	[SerializeField] DragNShoot iS;
    void OnCollisionEnter2D(Collision2D collison){
		if(collison.transform.tag != "Player"){
			if (!Input.GetMouseButtonDown (0)) {
				rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
				canRotate = true;
				//print ("Col");
				//print ("Enter");
			}
		} 
	}

	void Update()
	{
		if(iS.isStill == false){
			RotateObjectAroundZAxis();
		}
	}

	private void RotateObjectAroundZAxis()
	{
		transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Coin"))
		{
			Destroy(other.gameObject);
			cm.coinCount++;
		}
	}

}
