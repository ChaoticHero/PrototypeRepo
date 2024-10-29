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
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Enemy")
        {

            Destroy(this.gameObject);
            gamemanager.enemyhealth -= 5;
        }
        else
        {
            Destroy(this.gameObject, onscreenDelay);
        }
    }
}

