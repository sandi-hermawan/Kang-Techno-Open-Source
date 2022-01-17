using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static bool GameOverCondition;
    public GameObject GameOverscreen;
    // Start is called before the first frame update
    void Start()
    {
        GameOverCondition = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOverCondition)
        {
            GameOverscreen.SetActive(true);
            Time.timeScale = 1;
        }
    }

}
