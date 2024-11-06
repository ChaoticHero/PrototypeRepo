using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager Gamemanager;
    public float targetTime = 3.0f;
    Animator e_Animator;
    int rand;
    public int randmove;
    public Rigidbody enemyrb;
    private Vector3 startPos;
    public Vector3 targetPos;
    Vector3 newRotation = new Vector3(0, 90, 0);
    Vector3 oldRotation = new Vector3(0, -90, 0);
    Vector3 target = new Vector3(-4.8f, 1.38f, -7.093f);
    public float speed;
    public bool move;


    void Start()
    {
        Gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
        e_Animator = gameObject.GetComponent<Animator>();
        startPos = transform.position;
    }


    void Update()
    {
        targetTime -= Time.deltaTime;
        movearound();
        if (targetTime <= 0.0f)
        {
            Damage();
            rand = Random.Range(1, 7);
            randmove = Random.Range(0, 20);
            targetTime = 3.0f;
        }
        
    }

    void Damage()
    {
        if (rand >= 3)
        {
            e_Animator.Play("Punch");
        }
        else
        {
            e_Animator.Play("Sweep");
        }
    }
    void movearound()
    {
        if (randmove >= 12)
            move = true;
        else
            move = false;
        if (move)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            if (transform.position == targetPos)
            targetPos = startPos; 

            if ((transform.position == startPos)&& (move))
            {
            targetPos = new Vector3(-4.8f, 1.38f, -7.093f);
            }

            if(transform.position == target)
            {
            transform.eulerAngles = newRotation;
            }
            else if(transform.position == startPos)
            {
            transform.eulerAngles = oldRotation;
            }


        }
        if (rand >= 3)
        {
            move = false;
        }
        else
        {
            move = false;
        }
        move = true;



    }
}
