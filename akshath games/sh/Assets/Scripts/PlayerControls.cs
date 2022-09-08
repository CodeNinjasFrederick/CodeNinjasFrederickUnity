using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    public Rigidbody2D rb;
    public float downSpeed = 20f;
    public float movementSpeed = 10f;
    public float movement = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        if (movement < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;

        }else{
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
    private void OnCollisionEnter2D(Collision2D colision)
    {
        rb.velocity = new Vector3(rb.velocity.x, downSpeed, 0);
    }
}
