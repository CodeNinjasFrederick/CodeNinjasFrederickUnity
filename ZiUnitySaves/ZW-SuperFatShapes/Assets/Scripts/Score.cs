using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    //Score is 0
    public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Score is set to 0
        //when the game starts
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Text UI component equals to 
        //score as string
        GetComponent<UnityEngine.UI.Text>().text = score.ToString();
    }
}
