using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helmetcat : MonoBehaviour
{
    
    public SpriteRenderer catnohemlet;
    public SpriteRenderer catwithhemlet;
    public GameObject weakpoint;
    public float shiledcount = 3;
    public killcat catdeath;
    // Start is called before the first frame update
    void Start()
    {
        catdeath.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter2D(Collider2D other)
    {
  
        
        if(other.gameObject.CompareTag ("Bullet"))
        {
            Debug.Log("work");
            shiledcount -= 1;
        }
        if(shiledcount == 0)
        {
            catnohemlet.enabled = true;
          

            catwithhemlet.enabled = false;
        }
    }
}
