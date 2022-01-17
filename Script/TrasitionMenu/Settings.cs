using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    [Header("Panel Settings")]
    public GameObject settings;
    void Start()
    {

    }

    //menampilkan panel Shop
    public void ShowPanelSettings()
    {
        //Menampilkan Panel
        settings.SetActive(true);
        Time.timeScale = 0f;
    }
    //menutup panel shop
    public void ClosePanelSettings()
    {
        //Menutup Panel
        settings.SetActive(false);
        Time.timeScale = 1f;
    }
}
