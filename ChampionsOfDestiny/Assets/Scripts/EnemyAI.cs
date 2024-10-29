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
    public Rigidbody enemyrb;
    private Vector3 startPos;
    public Vector3 targetPos;
    Vector3 newRotation = new Vector3(0, 90, 0);
    Vector3 oldRotation = new Vector3(0, -90, 0);
    public float speed;
    void Start()
    {
        Gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
        e_Animator = gameObject.GetComponent<Animator>();
        startPos = transform.position;
    }


    void Update()
    {
        targetTime -= Time.deltaTime;

        Invoke("movearound",3.0f);
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
    void movearound()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (transform.position == targetPos)
            targetPos = startPos; //If you have reached the end position, set the start position to the target so you move back and forth.

        if (transform.position == startPos)
        {
            targetPos = new Vector3(-4.8f, 1.38f, -7.093f);
        }

        if(transform.position == targetPos)
        {
            transform.eulerAngles = oldRotation;
        }
        else if(transform.position == startPos)
        {
            transform.eulerAngles = newRotation;
        }
    }
}
