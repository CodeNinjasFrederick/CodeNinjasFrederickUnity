using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Game over canvas object
    public GameObject gameOverCanvas;
    //Hexagon game object
    public GameObject[] shapePrefabs;
    //Spawn rate for how many
    //objects are spawned
    public float spawnDelay = 1f;
    public float spawnTime = 2f;

    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }

    void Spawn()
    {
        int randomInt = Random.Range(0, shapePrefabs.Length);
        //Spawn new hexagon at position
        Instantiate(shapePrefabs[randomInt], Vector3.zero, Quaternion.identity);
    }

    public void GameOver()
    {
        //Game is at a stopping state
        Time.timeScale = 0;
        //Game over canvas is visible
        gameOverCanvas.SetActive(true);
        CancelInvoke("Spawn");
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
