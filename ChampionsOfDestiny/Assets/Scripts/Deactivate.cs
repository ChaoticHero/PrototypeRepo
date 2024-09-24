using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{

    public GameObject roundstarting;

    void Start()
    {
        roundstarting = GameObject.Find("Panel");
    }

    void Update()
    {
        
    }
    public void deactivate()
    {
        roundstarting.SetActive(false);

    }
}
