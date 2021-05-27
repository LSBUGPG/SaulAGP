using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallonplayer : MonoBehaviour
{
    public Rigidbody2D enemyrb;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            enemyrb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
