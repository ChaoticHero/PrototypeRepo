using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsScript : MonoBehaviour
{
    public GameObject Main;
    public GameObject controls;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Switchmain()
    {
        controls.SetActive(false);
        Main.SetActive(true);
    }

    public void SwitchControls()
    {
        controls.SetActive(true);
        Main.SetActive(false);
    }
}
