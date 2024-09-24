using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    // Start is called before the first frame update
    Collider p_Collider;
    public GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        p_Collider = GameObject.Find("Collider").GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            p_Collider.enabled = true;
        }
        else if(Input.GetKeyUp("z"))
        {
            p_Collider.enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().tag == "Enemy")
            gameManager.enemyhealth -= gameManager.attackdamage;
    }
}
