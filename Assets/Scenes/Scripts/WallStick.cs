using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallStick : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool canSling = false;

    void OnCollisionEnter2D(Collision2D collison){
		if(collison.transform.tag != "Player"){
			if (!Input.GetMouseButtonDown (0)) {
				rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
				//print ("Col");
				canSling = true;
				//print ("Enter");
			}
		} 
	}

	
	void OnCollisionStay2D(Collision2D collision){
		if(collision.transform.tag != "Player"){
			canSling = true;
		}
	}
}
