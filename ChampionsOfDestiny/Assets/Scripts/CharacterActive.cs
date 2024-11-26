using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterActive : MonoBehaviour
{
    public GameObject[] Charactermodels;
    [SerializeField] TextMeshProUGUI Characternames;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Player1()
    {
        Charactermodels[0].SetActive(true);
        Charactermodels[1].SetActive(false);
        Charactermodels[2].SetActive(false);
        Characternames.text = "Blue Player";
    }
    public void Player2()
    {
        Charactermodels[1].SetActive(true);
        Charactermodels[0].SetActive(false);
        Charactermodels[2].SetActive(false);
        Characternames.text = "Green Player";
    }

    public void Player3()
    {
        Charactermodels[0].SetActive(false);
        Charactermodels[1].SetActive(false);
        Charactermodels[2].SetActive(true);
        Characternames.text = "Orange Player";

    }
    public void Wrestler()
    {
        Charactermodels[0].SetActive(false);
        Charactermodels[1].SetActive(false);
        Charactermodels[2].SetActive(false);
        Charactermodels[3].SetActive(true);
        Characternames.text = "Wrestler";
    }
    public void Ninja()
    {
        Charactermodels[0].SetActive(false);
        Charactermodels[1].SetActive(false);
        Charactermodels[2].SetActive(false);
        Charactermodels[3].SetActive(false);
        Charactermodels[4].SetActive(true);
        Characternames.text = "Ninja";
    }
    public void turnoff()
    {
        Charactermodels[0].SetActive(false);
        Charactermodels[1].SetActive(false);
        Charactermodels[2].SetActive(false);
        Charactermodels[3].SetActive(false);
        Charactermodels[4].SetActive(false);
        Characternames.text = " ";
    }
}
