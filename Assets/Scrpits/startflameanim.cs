using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startflameanim : MonoBehaviour
{
    public SpriteRenderer flame;
    public AudioSource gong;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            flame.enabled = true;
            gong.Play();
        }
    }
}
