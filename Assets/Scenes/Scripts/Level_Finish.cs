using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Level_Finish : MonoBehaviour
{
    public GameObject Winscreen;
    public GameObject Ball;
    public TMP_Text rankText;
    public DeathCounter deathCounter;
    public Rigidbody2D rb;
	[SerializeField] DragNShoot iS;
    [SerializeField] DragNShoot lA;
    [SerializeField] PauseMenu iP;
    public float deathS = 0;
    public float deathA = 0;
    public float deathB = 0;
    public float deathC = 0;
    public float deathD = 0;
    public float deathF = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            StartCoroutine("Finish_Screen");
        }
    }

    private void rankLetter()
    {
        if (deathCounter.deathCount==deathS)
        {
            rankText.SetText("S");
            rankText.color = Color.red;
        }

        else if (deathCounter.deathCount>=deathA && deathCounter.deathCount<=deathB)
        {
            rankText.SetText("A");
            rankText.color = Color.yellow;
        }

        else if (deathCounter.deathCount>=deathB && deathCounter.deathCount<=deathC)
        {
            rankText.SetText("B");
            rankText.color = Color.cyan;
        }

        else if (deathCounter.deathCount>=deathC && deathCounter.deathCount<=deathD)
        {
            rankText.SetText("C");
            rankText.color = Color.green;
        }

        else if (deathCounter.deathCount>=deathD && deathCounter.deathCount<=deathF)
        {
            rankText.SetText("D");
            rankText.color = Color.blue;
        }

        else if (deathCounter.deathCount>=deathF)
        {
            rankText.SetText("F");
            rankText.color = Color.gray;
        }
    }
    
    private IEnumerator Finish_Screen()
    {
        Ball.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
        Ball.gameObject.GetComponent<LineRenderer>().enabled = false;
        Ball.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
        yield return new WaitForSecondsRealtime(1f);
        Winscreen.SetActive(true);
        rankLetter();
        iS.isStill = false;
        lA.launchable = false;
        
    }

}
