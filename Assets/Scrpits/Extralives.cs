using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extralives : MonoBehaviour
{
    public int livestogvie;
   public Health healthy;
  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            healthy.Addlives(livestogvie);
            Destroy(this.gameObject);
        }
     
    }
}
