using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public Rigidbody Rb_;
    public GameObject[] bullets;
    Animator m_Animator;
    int bulletType = 0;
    Vector3 newRotation = new Vector3(0, 90, 0);
    Vector3 oldRotation = new Vector3(0, -90, 0);
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.chargevalue > 299)
        {
            gameManager.chargevalue = 300;
        }
        if (Input.GetKeyDown("z"))
        {
            //gameManager.enemyhealth -= gameManager.attackdamage;
            m_Animator.Play("Punch");

        }
        if (Input.GetKey("x"))
        {
            gameManager.chargevalue += 1;
            
        }
        if (Input.GetKeyDown("c"))
        {
            if (gameManager.chargevalue <= 0)
            {

            }
            else if (gameManager.chargevalue >= 50)
            {
                m_Animator.Play("FireBall");
            }
        }
        if (Input.GetKeyDown("b"))
        {
            if (gameManager.chargevalue <= 0)
            {

            }
            else if (gameManager.chargevalue >= 200)
            {
                m_Animator.Play("ultimate");
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Animator.Play("Walking");
            Rb_.velocity = new Vector3(-3, 0, 0);
            transform.eulerAngles = oldRotation;
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Rb_.velocity += 5 * Vector3.up;
               
                //Rb_.AddForce(0, 100, 0);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Animator.Play("Walking");

            Rb_.velocity = new Vector3(3, 0, 0);
            transform.eulerAngles = newRotation;
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Rb_.velocity += 5 * Vector3.up;
                //Rb_.AddForce(0, 100, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Rb_.velocity += 7 * Vector3.up;
            m_Animator.Play("Jumping");
            //Rb_.AddForce(0, 100, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                m_Animator.Play("Duck");
                
            }
        if (Input.GetKeyDown("v"))
                {
                    m_Animator.Play("Sweep");
                }

    }

    public void FireballShoot()
    {
             GameObject newBullet = Instantiate(bullets[bulletType],
               this.transform.position + new Vector3(2, 1, 0),
                  this.transform.rotation) as GameObject;

                
                Rigidbody bulletRB =
                    newBullet.GetComponent<Rigidbody>();
        if (transform.eulerAngles == oldRotation)
        {
            bulletRB.velocity = new Vector3(-5, 0, 0);
        }
        else
        {
            bulletRB.velocity = new Vector3(5, 0, 0);
        }
                
                gameManager.chargevalue -= 50;
    }
}
