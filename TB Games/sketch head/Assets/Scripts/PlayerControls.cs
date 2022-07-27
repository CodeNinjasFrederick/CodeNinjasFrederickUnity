using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    //Rigidbody2D object thatis stored
    [Header("rigidbody")]
    pulblic Rigidbody2D rb;
   [Headder("Defalt Down Speed")]
    //downward speed of the object
    public float downSpeed = 20f;
    [Header("Defalt Directional Movement Speed")]
    //movement speed of the object 
    public float movementSpeed = 10f;
   
    [Header("Defalt Driectional Movement

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //variable equals to component Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
        //movement equals Horizontal movement
        //multiplied by the movement speed 
        movementSpeed = Input.GetAxis("Horizontal") * movementSpeed;
        // if direction on x axis is less than 0
        if (movementSpeed < 0 )
        {
            //object faces to the left
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        //if direction on x axis is greater than 0 
        else
        {
            //object faces to the right
            this.getComponent<SpriteRenderer>().flipX = true;
        }

        //Fixedupdatecalled every fixed frame frame-rate frame.
        void FixedUpdate()
        {
            //vector2 which is (x,y) velocity
            //equalsto the velocity of the rigidbody2D
            Vector2 velocity = rb.velocity;
            //Velocity of the x axis equals to 
            //the direction movement on the x axis
            //of the character
            velcity.x = movementSpeed;
            //Rigidbody2D velocity equals to 
            //velocity of the object
            rb.velocity = velocity;

        }
     //Collision function
     private void OnCollisionEnter2D(Collision 2D collision)
            {
            //velocity with the downspeed
            rb.velocity = new Vector3(rb.velocity.x, downSpeed, 0);
        }
    
    }

}
