using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScore;
    public static int highScoreValue = 0;
 
    public void Awake()
    {
        if(PlayerPrefs.HasKey("SaveScore"))
        {
            highScoreValue = PlayerPrefs.GetInt("SaveScore");
        }
    }

    void Start()
    {
        highScore.text = "SCORE " + highScoreValue;
    }

    public void HighScoreCount()
    {
        if(CountHitKnife.scoreValue > highScoreValue)
        {
            highScoreValue = CountHitKnife.scoreValue;
        }

        PlayerPrefs.SetInt("SaveScore", highScoreValue);
    }
}

