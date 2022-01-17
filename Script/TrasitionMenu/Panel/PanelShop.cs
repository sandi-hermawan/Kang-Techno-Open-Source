using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelShop : MonoBehaviour
{
    [Header("Panel Character")]
    public GameObject Character;
    [Header("Panel Skate")]
    public GameObject Skate;
    [Header("Panel Upgrade")]
    public GameObject Upgrade;

    //menampilkan panel Me
    public void ShowPanelCharacter()
    {
        //Menampilkan Panel
        Character.SetActive(true);
        Time.timeScale = 0;
    }
    public void ClosePanelCharacter()
    {
        //Menutup Panel
        Character.SetActive(false);
        Time.timeScale = 1;
    }
    public void ShowPanelSkate()
    {
        //Menampilkan Panel
        Skate.SetActive(true);
        Time.timeScale = 0;
    }
    public void ClosePanelSkate()
    {
        //Menutup Panel
        Skate.SetActive(false);
        Time.timeScale = 1;
    }
    public void ShowPanelUpgrade()
    {
        //Menampilkan Panel
        Upgrade.SetActive(true);
        Time.timeScale = 0;
    }
    public void ClosePanelUpgrade()
    {
        //Menutup Panel
        Upgrade.SetActive(false);
        Time.timeScale = 1;
    }
    public void ConditionopenCharacter()
    {
        ClosePanelUpgrade();
        ClosePanelSkate();
        ShowPanelCharacter();
    }
    public void ConditionopenSkate()
    {
        ClosePanelCharacter();
        ClosePanelUpgrade();
        ShowPanelSkate();
    }
    public void Conditionopenupgrade()
    {
        ClosePanelCharacter();
        ClosePanelSkate();
        ShowPanelUpgrade();
    }
}
