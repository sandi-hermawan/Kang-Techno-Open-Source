using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Booster1 : MonoBehaviour
{
    public GameObject CdText;
    public GameObject  CdPannel;

    public Text textJumlah;

    public int secondLeft = 3;

    private static bool setActiveCD ;
    private static bool setActiveCDShoe;
    public static bool takingAway = false;

    void Start()
    {
        textJumlah.text = "1";
        setActiveCD = false;
        setActiveCDShoe = false;
        CdText.GetComponent<Text>().text = "" + secondLeft;

    }

    void Update()
    {
        if(setActiveCD == true || setActiveCDShoe == true)
        {
            StartCD();

        }

    }

    public void StartCD()
    {
        setActiveCD = true;
        if (setActiveCD)
        {
            if (takingAway == false && secondLeft > 0 )
            {
                StartCoroutine(TimerTake());

                CdPannel.SetActive(true);
                //Player_2Jalur.forwardSpeed = 17;
            }
            
        }
    }
    public void StartCDShoe()
    {
        setActiveCDShoe = true;
        if (setActiveCDShoe)
        {
            if (takingAway == false && secondLeft > 0)
            {
                StartCoroutine(TimerTake());

                CdPannel.SetActive(true);
                Player_2Jalur.JumpPower = 15;
            }

        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondLeft -= 1;
        if (secondLeft < 1 )
        {
            CdText.GetComponent<Text>().text = "" + secondLeft;
            CdPannel.SetActive(false);
            Player_2Jalur.forwardSpeed = 14;
            Player_2Jalur.JumpPower = 8;

            textJumlah.text = "0";
        }
        else
        {
            CdText.GetComponent<Text>().text = "" + secondLeft;

        }
        takingAway = false;

    }

}
