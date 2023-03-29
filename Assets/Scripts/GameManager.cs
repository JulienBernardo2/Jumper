using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Text scoreText;
    public static int score;
    public static int totalScore;
    public static int previousLevelIndex = 0;
    public static int tempScore = 0;

    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(Instance);

        if(SceneManager.GetActiveScene().buildIndex == 4)
        {
            scoreText.text = "The score you had for the level was " + tempScore;
            tempScore = 0;
            score = totalScore;
        }
        else if(SceneManager.GetActiveScene().buildIndex == 5)
        {
            scoreText.text = "Your final score is " + score;
        } else
        {
            scoreText.text = "Score " + score;
        }
    }

    public void saveScene()
    {
        previousLevelIndex = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("PreviousLevelIndex", previousLevelIndex);
    }

    public void UpdateScore()
    {
        score += 50;
        tempScore = score;
        scoreText.text = "Score: " + score;       
    }

    public void ResetScore()
    {
        score = tempScore;
    }

    public void ResetAllScores()
    {
        score = 0;
        tempScore = 0;
        totalScore = 0;
    }

    public void SaveTotalScore()
    {
        totalScore = score;
    }
}