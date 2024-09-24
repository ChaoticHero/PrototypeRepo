using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeDisplay : MonoBehaviour
{
    public GameManager gamemanager;

    [SerializeField] private Text chargeText;
    void awake()
    {
        chargeText.text = "Player's charge: " + gamemanager.chargevalue;
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Update()
    {
      
            chargeText.text = "Player's charge: " + gamemanager.chargevalue;
       
    }
}