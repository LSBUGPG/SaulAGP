using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombmove : MonoBehaviour
{
    public float speed = 30f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = new Vector2(0, speed * -1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
