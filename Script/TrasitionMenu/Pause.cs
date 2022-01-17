using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [Header("Panel Pause Menu")]
    public GameObject PausePanel;

    void Start()
    {
    }

    //menampilkan panel Pause Menu
    public void ShowPanelPause()
    {
        //Menampilkan Panel
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    //menutup panel Pause Menu
    public void ClosePanelPause()
    {
        //Menutup Panel
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void MoveScene()
    {
        Scene sceneIni = SceneManager.GetActiveScene();

        if (sceneIni.name != "MainMenu")
        {
            SceneManager.LoadScene("MainMenu");
            Time.timeScale = 1f;

        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void Exite()
    {
        Application.Quit();
    }
}
