using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Level_Finish : MonoBehaviour
{
    public GameObject Winscreen;
    public TMP_Text rankText;
    public CoinManager coinManager;
    public DeathCounter deathCounter;
    public int Srank =31;
    public int Arank =26;
    public int Brank =22;
    public int Crank =16;
    public int Drank =10;
    public int Frank =5;
    public int deathS = 0;
    public int deathA = 0;
    public int deathB = 0;
    public int deathC = 0;
    public int deathD = 0;
    public int deathF = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Winscreen.SetActive(true);
            rankLetter();
            Time.timeScale = 0f;
        }
    }

    private void rankLetter()
    {
        if (coinManager.coinCount== Srank && deathCounter.deathCount==deathS)
        {
            rankText.SetText("S");
        }

        else if (coinManager.coinCount>=Arank && deathCounter.deathCount==deathA)
        {
            rankText.SetText("A");
        }

        else if (coinManager.coinCount>=Brank && deathCounter.deathCount==deathB)
        {
            rankText.SetText("B");
        }

        else if (coinManager.coinCount>=Crank && deathCounter.deathCount==deathC)
        {
            rankText.SetText("C");
        }

        else if (coinManager.coinCount>=Drank && deathCounter.deathCount==deathD)
        {
            rankText.SetText("D");
        }

        else if (coinManager.coinCount>=Frank && deathCounter.deathCount==deathF)
        {
            rankText.SetText("F");
        }
    }

}
