using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDNumber : MonoBehaviour
{
    static public int id;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Character(int data)
    {
        id += data;
    }
    void Numberinfo()
    {
        int number = id;
    }
}
