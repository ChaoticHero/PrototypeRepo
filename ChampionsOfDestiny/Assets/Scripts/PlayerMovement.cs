using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public Rigidbody Rb_;
    public GameObject[] bullets;
    int bulletType = 0;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            //gameManager.enemyhealth -= gameManager.attackdamage;
            
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
                GameObject newBullet = Instantiate(bullets[bulletType],
                  this.transform.position + new Vector3(2, 0, 0),
                     this.transform.rotation) as GameObject;


                Rigidbody bulletRB =
                    newBullet.GetComponent<Rigidbody>();
                bulletRB.velocity = new Vector3(20, 0, 0);
                gameManager.chargevalue -= 50;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rb_.velocity = new Vector3(-3, 0, 0);
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Rb_.velocity += 5 * Vector3.up;
                //Rb_.AddForce(0, 100, 0);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Rb_.velocity = new Vector3(3, 0, 0);
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Rb_.velocity += 5 * Vector3.up;
                //Rb_.AddForce(0, 100, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Rb_.velocity += 5 * Vector3.up;
            //Rb_.AddForce(0, 100, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Rb_.transform.localScale = new Vector3(0.7f, 0.4f, 0.7f);
                
            }
        else if(!Input.GetKey(KeyCode.DownArrow))
            {
                Rb_.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            }

    }
}
