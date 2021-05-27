using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Endlevel : MonoBehaviour
{

    public Collecteable collecteable;

    public Endlevel endlevel;
    public GameObject GameComplete;
    public Text timeleft;
    public Timer timer;
    public float timecount;
    public Text HighScoretext;
    public float HighScore;
    public float expert;
    public float normal;
    public float minextime;
    public GameObject fireworks;
    public GameObject clapping;
    
    // Start is called before the first frame update
    void Start()
    {



        timecount = timer.currentTime;
        timeleft.text = "timeleft" + timecount;
        
        

        Debug.Log(HighScore);
    }

    // Update is called once per frame
    void Update()
    {
        HighScore = collecteable.BoneCount + timecount;
        HighScoretext.text = "HighScore " + HighScore;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.CompareTag("Player"))
        {
            endlevel.enabled = true;
            GameComplete.SetActive(true);
            fireworks.SetActive(true);
           clapping.SetActive(true);
            Debug.Log(timer.currentTime);
            if (timer.currentTime >= minextime)
            {
                HighScore += expert;
            }
          
        }

    }

}
