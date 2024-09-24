using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundText : MonoBehaviour
{
    public GameManager gamemanager;

    [SerializeField] private Text roundtext;

    void awake()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
        roundtext.text = "Round " + gamemanager.rounds;
        
    }
    private void Update()
    {
        roundtext.text = "Round " + gamemanager.rounds;
    }
}
