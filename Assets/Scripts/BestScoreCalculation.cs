using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BestScoreCalculation : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    private AutosaveScore autoSaveScore;

    // Start is called before the first frame update
    void Start()
    {
        autoSaveScore = GameObject.Find("AutosaveHS").GetComponent<AutosaveScore>();
        if (MainManager.m_GameOver == true && MainManager.totalScore != 0)
        {
            autoSaveScore.SavePlayerScore(MainManager.totalScore);
        }
        autoSaveScore.LoadPlayerScore();
        bestScoreText.text = "Best score: " + AutosaveScore.bestPlayerName + ": " + AutosaveScore.bestScore.ToString();
    }
}
