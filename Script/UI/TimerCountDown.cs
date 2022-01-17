﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountDown : MonoBehaviour
{
    public GameObject textDisplay;

    public int secondLeft ;

    public static bool takingAway = false;

    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondLeft;
        StartCoroutine(TimerTake());

    }

    void Update()
    {
        if(takingAway == false && secondLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
    }
    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondLeft -= 1;
        if(secondLeft <10)
        {
            textDisplay.GetComponent<Text>().text = "00:0" + secondLeft;

        }
        else
        {
            textDisplay.GetComponent<Text>().text = "00:" + secondLeft;

        }
        takingAway = false;
    }
}
