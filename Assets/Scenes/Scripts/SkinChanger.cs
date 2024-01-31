using UnityEngine;
using System.Collections;

public class SkinChanger : MonoBehaviour {

	public SpriteRenderer spriteRenderer; //will store sprite renderer

	void Start()
	{
		spriteRenderer = gameObject.GetComponent<SpriteRenderer> (); //get sprite renderer & store it
	}

	public void change(Sprite differentSprite)
	{
		spriteRenderer.sprite = differentSprite; //sets sprite renderers sprite
	}
}
