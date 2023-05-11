using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
