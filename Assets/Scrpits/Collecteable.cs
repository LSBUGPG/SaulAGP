using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collecteable : MonoBehaviour
{

    public Shooting shoot;
    private AudioSource Audio;
    public Timer timerScrpit;
    public AudioClip collectSound;
    public Text scoreText;
    public int BoneCount = 0;
    public Image Dogfreed;

    void Start()
    {
        Audio = GetComponent<AudioSource>();

        Timer timerScrpit = GetComponent<Timer>();

    }
    void Update()
    {
        scoreText.text = "Bones: " + BoneCount;
    }


    void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.tag == "TimeBoost")
        {
            timerScrpit.currentTime += 5f;
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Bone")
        {

            BoneCount += 1;
            Audio.PlayOneShot(collectSound);
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "T-Bone")
        {

            BoneCount += 10;
            Audio.PlayOneShot(collectSound);
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("gun"))
        {

            shoot.enabled = true;

            Destroy(other.gameObject);

            shoot.BulletCount += 3;
        }
        if (other.gameObject.CompareTag("cageddog"))
        {
            Destroy(other.gameObject);
            Dogfreed.enabled = true;
        }

    }
}





















