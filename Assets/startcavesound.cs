using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class startcavesound : MonoBehaviour
{
    public AudioClip loopybit;

    AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Obj Entered Trigger");
            audio.loop = true;
            audio.clip = loopybit;
            audio.Play();

        }

    }


    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Object left Trigger");
            audio.Stop();
        }
           
    }

}