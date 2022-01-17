using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class Play : MonoBehaviour
{
    [Header("Panel Level")]
    public GameObject level;

    

    public void Level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }
    public void PlayLevel()
    {
     
    level.SetActive(true);
        Time.timeScale = 0f;
    }
    public void CloseLevel()
    {
        level.SetActive(false);
        Time.timeScale = 1f;
    }
}