using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreNumber, bestNumber;
    public GameObject scorePanel;

    int score, bestscore;

   
    private void Awake()
    {
        instance = this;

        if (PlayerPrefs.HasKey("BestScore"))
        {
            bestscore = PlayerPrefs.GetInt("BestScore");
        }
        else
        {
            bestscore = 0;
        }
    }

    public void ScoreUpdate()
    {
        score++;
        scoreText.text = score.ToString();  
    }

    public void DisplayDeathPanel()
    {
        scorePanel.SetActive(true);
        scoreNumber.text = score.ToString();
        bestNumber.text = bestscore.ToString();

        if (score > bestscore)
        {
            PlayerPrefs.SetInt("BestScore",score);
        }
    }
}
