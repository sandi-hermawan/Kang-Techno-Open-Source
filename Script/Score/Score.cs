
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Score : MonoBehaviour
{

    private float score = 0f;

    public TextMeshProUGUI scoreText;

    public static string ScoretextResult;

    public static bool scoreSetAktive = false;

    private void Start()
    {
        scoreSetAktive = true;
    }
    private void Update()
    {
        if (scoreSetAktive) {

            score += Time.deltaTime * 23.0f;
            scoreText.text = ((int)score).ToString();
            ScoretextResult = scoreText.text;
        }
        if(Player_2Jalur.Health == 2)
        {
            scoreText.text = ((int)score - 100).ToString();

            ScoretextResult = scoreText.text;
        }
        if (Player_2Jalur.Health == 1)
        {
            scoreText.text = ((int)score - 200).ToString();

            ScoretextResult = scoreText.text;
        }

    }
    public static void StopScore()
    {
        scoreSetAktive = false;
    }
}

