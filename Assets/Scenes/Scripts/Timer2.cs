using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText2;
    float elapsedTime;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timerText2.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }   
}
