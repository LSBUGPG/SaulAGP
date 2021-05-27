using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public Transform  PlayerTransform;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void LateUpdate()
    {
        Vector3 Temp = transform.position;

        Temp.x = PlayerTransform.position.x;
        Temp.y = PlayerTransform.position.y;
        Temp.y += offset;
        Temp.x += offset;
        transform.position = Temp;
    }
}
