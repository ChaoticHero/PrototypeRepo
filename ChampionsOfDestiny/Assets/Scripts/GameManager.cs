using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject roundstarting;
    public GameObject data;
    public int enemyhealth;
    public int chargevalue;
    public int Playerhealth;
    public int attackdamage;
    public int rounds;
    public int playerWins;
    public int EnemyWins;
    public float x, y, z;
    public float x1, y1, z1;
    public int characterid;
    public GameObject[] Playermodels;
    // Start is called before the first frame update
    void Start()
    {
        characterid = IDNumber.id;
        rounds = 1;
        enemyhealth = 100;
        Playerhealth = 100;
        attackdamage = 10;    


        if (characterid == 0)
        {
            Playermodels[characterid].SetActive(true);
        }
        else
        {
            Playermodels[characterid].SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (TimerScript.TimeLeft <= 0f)
        {
            if (enemyhealth < Playerhealth)
            {
                playerwins();
                round();
                //Winningscene();

            }
            else if (Playerhealth < enemyhealth)
            {
                enemywins();
                round();
            }
            else if (Playerhealth == enemyhealth)
            {
                tie();
            }
        }
        if (enemyhealth <= 0)
        {
            playerwins();
            round();
            //Winningscene();

        }
        else if (Playerhealth <= 0) 
        {
            enemywins();
            round();
        }
        if (playerWins == 2)
        {
            Winningscene();
        }
        else if (EnemyWins == 2)
        {
            Losingscene();
        }
    }


    void Winningscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    void Losingscene()
    {
        SceneManager.LoadScene(4);
    }
    public void round()
    {
        TimerScript.TimeLeft += 60f;
        roundstarting.SetActive(true);
    }

    public void playerwins()
    {
        rounds += 1;
        playerWins += 1;
        enemyhealth = 100;
        Playerhealth = 100;
        Debug.Log("The player has " + playerWins);
        PlayerMovement player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        player.transform.position = new Vector3(x, y, z);
        EnemyAI enemy = GameObject.Find("Enemy").GetComponent<EnemyAI>();
        enemy.transform.position = new Vector3(x1, y1, z1);
    }

    public void enemywins()
    {
        rounds += 1;
        EnemyWins += 1;
        Playerhealth = 100;
        enemyhealth = 100;
        Debug.Log("The enemy has " + EnemyWins);
        PlayerMovement player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        player.transform.position = new Vector3(x, y, z);
        EnemyAI enemy = GameObject.Find("Enemy").GetComponent<EnemyAI>();
        enemy.transform.position = new Vector3(x1, y1, z1);
    }

    public void tie()
    {
        rounds += 1;
        Playerhealth = 100;
        enemyhealth = 100;
        PlayerMovement player = GameObject.Find("Player").GetComponent<PlayerMovement>();
        player.transform.position = new Vector3(x, y, z);
        EnemyAI enemy = GameObject.Find("Enemy").GetComponent<EnemyAI>();
        enemy.transform.position = new Vector3(x1, y1, z1);
    }
}
