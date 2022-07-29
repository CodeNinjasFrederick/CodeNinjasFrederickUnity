using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Game over Canvas 
    [ Header("Game Over UI Canvas Object")]
    public void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.Find("DoodleHead").setActive(false);
        GameObject.Find("Gamecontroller").getCompont<GameController>().GameOver();
    }
    //Game over function
    public void GameOver()
    {
        //Game Over Canvas is active 
    }
}
