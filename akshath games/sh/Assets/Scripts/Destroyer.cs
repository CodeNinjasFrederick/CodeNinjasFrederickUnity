using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    GameObject.Find("DoodleHead").SetActive(false);
    GameObject.Find("GameController").GetComponent<GameController>().GameOver();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
