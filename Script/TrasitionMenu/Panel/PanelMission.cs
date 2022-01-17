using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelMission : MonoBehaviour
{
    [Header("Panel Misi")]
    public GameObject Misi;
    [Header("Panel Achivement")]
    public GameObject Achivement;

    public void ShowPanelMisi()
    {
        //Menampilkan Panel
        Misi.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ClosePanelMisi()
    {
        //Menutup Panel
        Misi.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ShowPanelAchivement()
    {
        //Menampilkan Panel
        Achivement.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ClosePanelAchivement()
    {
        //Menutup Panel
        Achivement.SetActive(false);
        Time.timeScale = 0f;
    }
    public void ConditionopenMission() {
        ClosePanelAchivement();
        ShowPanelMisi();
    }
    public void ConditionopenAcievement() {
        ClosePanelMisi();
        ShowPanelAchivement();
    }
}
