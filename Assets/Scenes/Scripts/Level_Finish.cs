using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Level_Finish : MonoBehaviour
{
    public GameObject Winscreen;
    public TMP_Text rankText;
    public DeathCounter deathCounter;
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
            Winscreen.SetActive(true);
            rankLetter();
        }
    }

    private void rankLetter()
    {
        if (deathCounter.deathCount==deathS)
        {
            rankText.SetText("S");
        }

        else if (deathCounter.deathCount>=deathA && deathCounter.deathCount<=deathB)
        {
            rankText.SetText("A");
        }

        else if (deathCounter.deathCount>=deathB && deathCounter.deathCount<=deathC)
        {
            rankText.SetText("B");
        }

        else if (deathCounter.deathCount>=deathC && deathCounter.deathCount<=deathD)
        {
            rankText.SetText("C");
        }

        else if (deathCounter.deathCount>=deathD && deathCounter.deathCount<=deathF)
        {
            rankText.SetText("D");
        }

        else if (deathCounter.deathCount>=deathF)
        {
            rankText.SetText("F");
        }
    }

}
