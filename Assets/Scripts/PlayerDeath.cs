using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class PlayerDeath : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            GameManager.Instance.ResetScore();
            GameManager.Instance.saveScene();
            SceneManager.LoadScene(4);
        }
    }
}
