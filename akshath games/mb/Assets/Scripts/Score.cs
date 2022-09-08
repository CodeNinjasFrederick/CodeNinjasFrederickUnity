using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [Header("Default Score")]
    public static int score = 0;

    public void Start()
    {
        score = 0;
    }

    public void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
