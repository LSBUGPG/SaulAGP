using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cavesounds : MonoBehaviour
{
    public AudioClip loopycave;

   public AudioSource caveaudio;

    void Start()
    {
       caveaudio  = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Obj Entered Trigger");
            caveaudio.loop = true;
            caveaudio.clip = loopycave;
            caveaudio.Play();
        }
  

    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Object left Trigger");
            caveaudio.Stop();
        }
            
    }

} 


