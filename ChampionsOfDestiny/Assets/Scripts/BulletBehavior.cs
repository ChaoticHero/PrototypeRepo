using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    // 1
    public float onscreenDelay = 3f;
    GameManager gamemanager;
    void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {

            Destroy(this.gameObject, onscreenDelay);
            gamemanager.enemyhealth -= 5;
        }
        else
        {
            Destroy(this.gameObject, onscreenDelay);
        }
    }
}

