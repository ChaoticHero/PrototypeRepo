using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider k_Collider;
    public GameManager gameManager;
    public Animator enemy;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Enemy")
        {
            gameManager.enemyhealth -= gameManager.attackdamage;
            enemy.Play("Hurt");
        }
    }
}
