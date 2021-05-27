using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationScrpit : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject bone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bone.transform.Rotate(0.0f, rotationSpeed*Time.deltaTime, 0.0f,Space.World);
    }
}
