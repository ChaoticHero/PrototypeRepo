﻿using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    static public float TimeLeft;
    public bool TimerOn = false;

    public Text TimerTxt;
   
    void Start()
    {
        TimeLeft = 60f;
        TimerOn = true;
    }

    void Update()
    {
        if(TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Time is UP!");
                TimeLeft = 0;
                TimerOn = false;
            }
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