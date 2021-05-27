using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterjump : MonoBehaviour
{
    public float fallmulti = 2.5f;
    public float lowjumpmulti = 2f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update() 
    {
        if(rb.velocity.y < 0){
            rb.velocity += Vector2.up* Physics2D.gravity.y *(fallmulti- 1) * Time.deltaTime;
        }
    }
}
