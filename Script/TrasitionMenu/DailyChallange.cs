using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DailyChallange : MonoBehaviour
{
    [Header("Panel Daily Challange")]
    public GameObject Daily;
    public GameObject Mission;

    public void ShowPanelDaily()
    {
        //Menampilkan Panel utama
        Daily.SetActive(true);
        //Menampilkan Panel sub 
        Mission.SetActive(true);
        Time.timeScale = 0f;
    }
    //menutup panel Daily challange
    public void ClosePanelDaily()
    {
        //Menutup Panel
        Daily.SetActive(false);
        Time.timeScale = 1f;
    }
}
