using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoard : MonoBehaviour
{
    [Header("Panel LeaderBoard")]
    public GameObject leaderboard;
    void Start()
    {

    }

    //menampilkan panel LeaderBoard
    public void ShowPanelLeaderBoard()
    {
        //Menampilkan Panel
        leaderboard.SetActive(true);
        Time.timeScale = 0f;
    }
    //menutup panel LeaderBoard
    public void ClosePanelLeaderBoard()
    {
        //menutup Panel
        leaderboard.SetActive(false);
        Time.timeScale = 1f;
    }
}
