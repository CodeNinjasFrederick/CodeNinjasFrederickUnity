using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    //Movement speed
    public float moveSpeed = 600f;
    //Movement float
    float movement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Game running at a playing state
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement equals to the horizontal
        //axis movement(Left or Right)
        movement = Input.GetAxisRaw("Horizontal");
    }

    //Fixed Update called every fixed frame-rate frame
    private void FixedUpdate()
    {
        //Object transformation rotates around
        //an object using the settings
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    //If the object collides with a 
    //collider with a trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Game Over function is called from the game manager
        GameObject.Find("GameController").GetComponent<GameController>().GameOver();
    }
}
