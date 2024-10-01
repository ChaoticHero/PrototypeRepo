using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager Gamemanager;
    float targetTime = 6.0f;
    Animator e_Animator;

    void Start()
    {
        Gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
        e_Animator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            Damage();
            targetTime = 6.0f;
        }
        
    }

    void Damage()
    {
        e_Animator.Play("Punch");
    }
}
