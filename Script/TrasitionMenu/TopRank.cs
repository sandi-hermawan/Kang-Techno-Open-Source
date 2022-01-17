using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopRank : MonoBehaviour
{
    [Header("Panel TopRank")]
    public GameObject toprank;


    //menampilkan panel TopRank
    public void ShowPanelTopRank()
    {
        //Menampilkan Panel
        toprank.SetActive(true);
        Time.timeScale = 0f;
    }
    //menutup panel TopRun
    public void ClosePanelTopRank()
    {
        //Menutup Panel
        toprank.SetActive(false);
        Time.timeScale = 1f;
    }
}
