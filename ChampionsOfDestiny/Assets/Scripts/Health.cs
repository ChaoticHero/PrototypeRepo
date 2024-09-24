using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public GameManager gamemanager;

    [SerializeField] private Text enemyText;
    void awake()
    {
        enemyText.text = "Enemy Health: " + gamemanager.enemyhealth;
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    private void Update()
    {
            enemyText.text = "Enemy Health: " + gamemanager.enemyhealth;

    }
}
