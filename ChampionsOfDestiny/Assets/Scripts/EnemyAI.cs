using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager Gamemanager;
    float targetTime = 2.0f;
    void Start()
    {
        Gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            Damage();
        }
        
    }

    void Damage()
    {
        
    }
}
