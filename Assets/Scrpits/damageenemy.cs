using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageenemy : MonoBehaviour
{
    public int health = 20;
    public GameObject enemy;
    public GameObject blood;
    public AudioClip deathnoise;
    private AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            health-=20;
        }
        if(health == 0)
        {
            Instantiate(blood, transform.position, Quaternion.identity);
            Audio.PlayOneShot(deathnoise);

            Destroy(enemy);

        }
    }
}
