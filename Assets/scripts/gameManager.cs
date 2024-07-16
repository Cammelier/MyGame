using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreNumber, bestNumber;
    public GameObject scorePanel, playButton;

    int score, bestscore;
    public bool gamePlayed;
    bool recordsoundPlayed;
   
    private void Awake()
    {
        instance = this;
        Time.timeScale = 0;

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
        
        if(score >= bestscore){
            if(recordsoundPlayed == false)
            {
                audioManager.instance.PlayRecord();
                recordsoundPlayed = true;
            }
        }
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

    public void PlayButton()
    {
        Time.timeScale = 1; 
        playButton.SetActive(false);
        gamePlayed = true;
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(0);
    }
}
