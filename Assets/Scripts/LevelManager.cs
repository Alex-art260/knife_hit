using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
   [SerializeField] private HighScoreLevel _highScoreLevel;

   public static bool checkLevel = false;
   public void MainMenu()
    {
        SceneManager.LoadScene("01_Menu");
    }

    public void LoadLevel()
    {
        checkLevel = true;
        SceneManager.LoadScene("02_Level");
        CountLevel.countLevelValue += 1;
        _highScoreLevel.HighScoreLevelCount();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("02_Level");
        CountApple.appleValue = 0;
        CountHitKnife.scoreValue = 0;
        CountLevel.countLevelValue = 1;
    }

    public void GameOver()
    {
        SceneManager.LoadScene("03_GameOver");
    }
}
