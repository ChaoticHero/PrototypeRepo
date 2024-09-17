using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int enemyhealth;
    int chargevalue;
    int Playerhealth;
    int attackdamage;
    [SerializeField] private Text enemyText;
    [SerializeField] private Text chargeText;
    // Start is called before the first frame update
    void Start()
    {
        enemyhealth = 100;
        attackdamage = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            enemyhealth -= attackdamage;
            enemyText.text = enemyhealth.ToString();
            enemyText.text = "Enemy Health: " + enemyhealth;
            Debug.Log("The enemy Health is at " + enemyhealth);
        }   
        if (Input.GetKey("x"))
        {
            chargevalue += 1;
            chargeText.text = "Player Charge: " + chargevalue;
        }
        if (enemyhealth <= 0)
        {
            enemyhealth = 0;
            attackdamage = 0;
            Winningscene();

        }

    }


    void Winningscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
