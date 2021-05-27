using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killcat : MonoBehaviour
{
    public GameObject cat;

    public GameObject blood;
    public AudioClip enterSound;

    private AudioSource Audio;
    public int EnemyHealth = 30;    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {


            EnemyHealth -= 10;
       
        }
            if (EnemyHealth == 0)
            {
        
                
                Audio.PlayOneShot(enterSound);
            Instantiate(blood, transform.position, Quaternion.identity);
            Destroy(gameObject,1f);

            }
        }

    }

 