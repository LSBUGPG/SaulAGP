using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform leftpoint;
    public Transform Rightpoint;
    private Rigidbody2D rb;
    public bool movingRight;
    public float moveSpeed;
    public SpriteRenderer Cat;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (movingRight && transform.position.x > Rightpoint.position.x)
        {
            movingRight = false;
            Cat.flipX = true;
        }
        if (!movingRight && transform.position.x < leftpoint.position.x)
        {
            movingRight = true;
            Cat.flipX = false;
        }
        if (movingRight)
        {
            rb.velocity = new Vector3(moveSpeed, rb.velocity.y, 0f);
        }
        else
        {
            rb.velocity = new Vector3(-moveSpeed, rb.velocity.y, 0f);
        }
    }
}




	// Use this for initialization


  
        

    
        

   
    
