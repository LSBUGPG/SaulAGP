using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tempScrpit : MonoBehaviour
{
    public float Speed;
    private float pos;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        pos = +Speed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(pos, 0);
    }
}
