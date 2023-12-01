using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject portal;
    private GameObject Ball;
    public float distance = 0.8f;

    void Start()
    {
        Ball = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(Vector2.Distance(transform.position, collision.transform.position) > distance && collision.tag == "Player")
        {
            Ball.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);
        }
    }
}
