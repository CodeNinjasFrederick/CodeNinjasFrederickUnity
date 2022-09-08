using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("game over UI")]
    public GameObject gameOverCanvas;
        [Header("score UI")]
        public GameObject scoreCanvas;
    [Header("spawner")]
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        scoreCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        spawner.SetActive(true);
    }

    public void gameover()
    {
        gameOverCanvas.SetActive(true); 
        spawner.SetActive(false);
        Time.timeScale = 0;
    }
}
