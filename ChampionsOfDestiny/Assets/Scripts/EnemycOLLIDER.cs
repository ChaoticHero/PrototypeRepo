using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemycollider : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider e_Collider;
    public GameManager gameManager;
    public Animator player;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.GetComponent<Collider>().name == "Player")
        {
            gameManager.Playerhealth -= gameManager.attackdamage;
            gameManager.PlayerHealthBar.fillAmount = gameManager.Playerhealth / 100f;
            player.Play("Hurt");
            Debug.Log("This should work.");
        }
    }
}
