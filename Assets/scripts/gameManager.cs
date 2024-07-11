using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;
    public TextMeshProUGUI scoreText;

    int score;
   
    private void Awake()
    {
        instance = this;
    }

    public void ScoreUpdate()
    {
        score++;
        scoreText.text = score.ToString();  
    }
}
