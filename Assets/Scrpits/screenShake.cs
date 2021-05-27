using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class screenShake : MonoBehaviour
{
  
    private float ShakeTimeLeft, ShakePower, ShakefadeTime, ShakeRotation;
    public float rotationamount = 15f;
     void Start()
    {
        
    }

     void Update()
    {
        
    }
    private void LateUpdate()
    {
        if (ShakeTimeLeft > 0)
        {
            ShakeTimeLeft -= Time.deltaTime;
            float xAmount = Random.Range(-1f, 1f) * ShakePower;
            float yAmount = Random.Range(-1f, 1f) * ShakePower;

            transform.position += new Vector3(xAmount, yAmount, 0f);
            
            ShakePower = Mathf.MoveTowards(ShakePower, 0f, ShakefadeTime * Time.deltaTime);
            ShakeRotation = Mathf.MoveTowards(ShakeRotation, 0f, ShakefadeTime * rotationamount * Time.deltaTime);
        }

        transform.rotation = Quaternion.Euler(0f, 0f, ShakeRotation * Random.Range(-1f, 1f));
}
public void StartShake(float length, float power)
{
        ShakeTimeLeft = length;
        ShakePower = power;

        ShakefadeTime = power / length;

        ShakeRotation = power * rotationamount;
}
}
