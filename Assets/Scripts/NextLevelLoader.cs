using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelLoader : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            if(SceneManager.GetActiveScene().buildIndex == 3)
            {
                SceneManager.LoadScene(5);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            GameManager.Instance.SaveTotalScore();
        }
    }
}
