using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScoreCalculation : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    private AutosaveScore autoSaveScore;

    // At start, check if the game was just gameover to store the data into the json

    void Start()
    {
        autoSaveScore = GameObject.Find("AutosaveHS").GetComponent<AutosaveScore>();

        // Check if a game was just happened
        if (MainManager.m_GameOver == true && MainManager.totalScore != 0)
        {
            //Load the best score data to compare with the last game
            autoSaveScore.LoadPlayerScore();
            //Only save score if the last one is better than the best score
            if (AutosaveScore.bestScore < MainManager.totalScore)
            {
                autoSaveScore.SavePlayerScore(MainManager.totalScore);
            }
        }

        //load data to display the best score.
        autoSaveScore.LoadPlayerScore();
        bestScoreText.text = "Best score: " + AutosaveScore.bestPlayerName + ": " + AutosaveScore.bestScore.ToString();
    }
}
