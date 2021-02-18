using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreLevel : MonoBehaviour
{
    public Text highScoreLevel;
    public static int highScoreLevelValue = 0;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("SaveLevel"))
        {
            highScoreLevelValue = PlayerPrefs.GetInt("SaveLevel");
        }
    }
    private void Start()
    {
        highScoreLevel.text = "LEVEL " + highScoreLevelValue;
    }

    public void HighScoreLevelCount()
    {
        if (CountLevel.countLevelValue > highScoreLevelValue)
        {
            highScoreLevelValue = CountLevel.countLevelValue;
        }

        PlayerPrefs.SetInt("SaveLevel", highScoreLevelValue);
    }
}
