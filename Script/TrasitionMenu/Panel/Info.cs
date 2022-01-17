using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour
{
    [Header("Panel Info Aplikasi")]
    public GameObject info;

    //menampilkan panel Shop
    public void ShowPanelInfo()
    {
        //Menampilkan Panel
        info.SetActive(true);
        Time.timeScale = 1f;
    }
    //menutup panel shop
    public void ClosePanelInfo()
    {
        //Menampilkan Panel
        info.SetActive(false);
        Time.timeScale = 1f;
    }
}
