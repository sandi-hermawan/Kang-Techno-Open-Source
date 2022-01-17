using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMe : MonoBehaviour
{
    [Header("Panel Character")]
    public GameObject Character;
    [Header("Panel Skate")]
    public GameObject Skate;

    //menampilkan panel Me
    public void ShowPanelCharacter()
    {
        //Menampilkan Panel
        Character.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ClosePanelCharacter()
    {
        //Menutup Panel
        Character.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ShowPanelSkate()
    {
        //Menampilkan Panel
        Skate.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ClosePanelSkate()
    {
        //Menutup Panel
        Skate.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ConditionopenCharacter()
    {
        ClosePanelSkate();
        ShowPanelCharacter();
    }
    public void ConditionopenSkate()
    {
        ClosePanelCharacter();
        ShowPanelSkate();
    }
}
