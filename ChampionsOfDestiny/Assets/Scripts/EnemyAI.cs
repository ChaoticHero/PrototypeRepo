using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager Gamemanager;
    float targetTime = 3.0f;
    Animator e_Animator;
    int rand;
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
            rand = Random.Range(1, 7);
            targetTime = 3.0f;
        }
        
    }

    void Damage()
    {
        Debug.Log("This number is" + rand);
        if (rand >= 3)
        {
            e_Animator.Play("Punch");
        }
        else
        {
            e_Animator.Play("Sweep");
        }
    }
}
