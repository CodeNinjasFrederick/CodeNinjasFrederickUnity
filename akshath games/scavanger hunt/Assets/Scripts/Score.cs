using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [Header("Default Score")]
    public int score = 0;
    [Header("Text Object for Displaying Score")]
    public Text scoreText;

    public void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }


    public void AddScore(int points)
    {
        score = score + points;
        scoreText.text = "Score: " + score.ToString();
    }
}
