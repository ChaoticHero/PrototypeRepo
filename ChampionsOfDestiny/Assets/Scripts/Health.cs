using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    private int health = 100;

    [SerializeField] private Text enemyText;
    void awake()
    {
        enemyText.text = health.ToString();
    }
    private void update(int health)
    {
        if (Input.GetKey("z"))
        {
            health -= 10;
            enemyText.text = "Enemy Health: " + health;
            enemyText.text = health.ToString();
        }
    }
}
