using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Me : MonoBehaviour
{
    [Header("Panel Me")]
    public GameObject AboutMe;
    public GameObject MeSkate;
    //menampilkan panel Me
    public void ShowPanelMe()
    {
        //Menampilkan Panel utama
        AboutMe.SetActive(true);
        //Menampilkan Panel sub 
        //MeSkate.SetActive(false);
        Time.timeScale = 0f;
    }
    //menutup panel Me
    public void ClosePanelMe()
    {
        //Menutup Panel
        AboutMe.SetActive(false);
        Time.timeScale = 1f;
    }
}
