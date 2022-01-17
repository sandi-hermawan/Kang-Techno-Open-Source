using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [Header("Panel Shop")]
    public GameObject shop;
    [Header("Panel Character")]
    public GameObject character;

    //menampilkan panel Shop
    public void ShowPanelShop()
    {
        //Menampilkan Panel
        shop.SetActive(true);
        character.SetActive(true);
        Time.timeScale = 0f;
    }
    //menutup panel shop
    public void ClosePanelShop()
    {
        //Menutup Panel
        shop.SetActive(false);
        Time.timeScale = 1f;
    }
}
