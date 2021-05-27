using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class starwind : MonoBehaviour
{
    public AudioSource source;
    public AudioClip wind;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            playSound();
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        stopSound();


    }

    void playSound()
    {
        source.Play();

    }



    void stopSound()
    {
        source.Stop();
    }
}