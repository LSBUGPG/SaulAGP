using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroybirck : MonoBehaviour
{
    public GameObject block;
    private Animator anim;
    public GameObject brickboom;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("fist"))
        {
            Instantiate(brickboom, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("fist"))
        {
            Instantiate(brickboom, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
 
        
    }
}
