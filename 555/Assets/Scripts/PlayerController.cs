using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed;
    public float jump;
    float moveVelocity;

    private int entered = 0;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //hüpe
        if (Input.GetKeyDown(KeyCode.Space) ||
            Input.GetKeyDown(KeyCode.W))
            if (grounded())
            {
                rb.velocity = new Vector2(rb.velocity.x, jump);

            }
        {
            
        }
        moveVelocity = 0;

        //horisontaalne liikumine vasa parem
        

        if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow))
        {
            moveVelocity = -speed; // liigub vasakule
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveVelocity = speed; // liigub paremale
        }

        rb.velocity = new Vector2(moveVelocity, rb.velocity.y);
    }


    //kas on maandatud
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Ground"))
            entered++;
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("Ground"))
            entered--;
    }

    bool grounded()
    {
        return entered > 0;
    }
        
      

}

