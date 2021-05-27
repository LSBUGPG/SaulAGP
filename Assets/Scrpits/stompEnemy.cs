using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stompEnemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject blood;
    public GameObject cageboom;
    public float BounceForce;
    private AudioSource Audio;
    public AudioClip enterSound;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.parent.GetComponent<Rigidbody2D>();
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {

         
            Audio.PlayOneShot(enterSound);
            Instantiate(blood, transform.position, Quaternion.identity);
            rb.velocity = new Vector3(rb.velocity.x, BounceForce, 0f);
            Destroy(other.gameObject);
        }
        if(other.tag == "cageddog")
        {
            Destroy(other.gameObject);
            Instantiate(cageboom,transform.position,Quaternion.identity);
        }
    }
}
