﻿using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    static public float TimeLeft;

    public Text TimerTxt;
   
    void Start()
    {
        TimeLeft = 60f;
    }

    void Update()
    {
        
        TimeLeft -= Time.deltaTime;
         updateTimer(TimeLeft);
        if (TimeLeft == 0)
        {
            Debug.Log("Time is UP!");
            TimeLeft = 0;
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 61);

        TimerTxt.text = string.Format("{00}", seconds);
    }

}