using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreApple : MonoBehaviour
{
    public Text highScoreApple;
    public static int highScoreAppleValue = 0;

    private void Awake()
    {
        if(PlayerPrefs.HasKey("SaveScoreApple"))
        {
            highScoreAppleValue =  PlayerPrefs.GetInt("SaveScoreApple");
        }
    }
    private void Update()
    {
        highScoreApple.text = " " +  highScoreAppleValue;
    }

    public void HighScoreAppleCount()
    {
        PlayerPrefs.SetInt("SaveScoreApple", highScoreAppleValue);
    }
}
