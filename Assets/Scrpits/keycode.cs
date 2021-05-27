using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keycode : MonoBehaviour
{
    public opendoor door;
    public GameObject key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            door.enabled = true;
            Destroy(key);
        }
    }
}
