using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText2;
    [SerializeField] GameObject Winscreen;
    float elapsedTime;
    bool isPaused = false;

    void Update()
    {
        if (!isPaused){
            elapsedTime += Time.deltaTime;
            int minutes = Mathf.FloorToInt(elapsedTime / 60);
            int seconds = Mathf.FloorToInt(elapsedTime % 60);
            timerText2.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

        if(Winscreen.activeInHierarchy)
        {
          PauseTimer();
        }
    }  

    public void PauseTimer()
    {
        isPaused = true;
    } 
}
