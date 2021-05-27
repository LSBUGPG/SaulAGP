using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
   public float currentTime = 0f;
    float statringTime = 300f;
  public Text countDownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = statringTime;
    }

    // Update is called once per frame
    void Update()
    {

        currentTime -= Time.deltaTime;
        countDownText.text = ""  + currentTime;
        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}