using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("Game controller object for controling the game")]
    public GameController gameController;
    [Header("default velocity")]
    public float velocity = 1;
    private Rigidbody2D rb;
    private float objectHeight;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GetComponent<GameController>();
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y/2;
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Find("GameController").GetComponent<GameController>().gameover();
    }
}
