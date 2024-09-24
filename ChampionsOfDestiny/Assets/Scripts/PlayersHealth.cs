using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersHealth : MonoBehaviour
{
    public GameManager gamemanager;

    [SerializeField] private Text playerText;
    void awake()
    {
        playerText.text = "Players Health: " + gamemanager.Playerhealth;
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Update()
    {
        playerText.text = "Players Health: " + gamemanager.Playerhealth;

    }
}
