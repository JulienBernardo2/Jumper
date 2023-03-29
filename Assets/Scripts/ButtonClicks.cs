using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClicks : MonoBehaviour
{
    public void OnClickRestart()
    {
        int previousLevelIndex = PlayerPrefs.GetInt("PreviousLevelIndex");
        SceneManager.LoadScene(previousLevelIndex);
    }

    public void OnClickMainMenu()
    {
        GameManager.Instance.ResetAllScores();
        SceneManager.LoadScene(0);
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene(1);
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
