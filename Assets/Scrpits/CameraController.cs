using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    public float followahead;

    private Vector3 targetPos;
    void Update()
    {
        targetPos = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);
        if (target.transform.localScale.x > 0f)
        {
            targetPos = new Vector3(targetPos.x + followahead, targetPos.y, targetPos.z);

        }
        else
        {
            targetPos = new Vector3(targetPos.x - followahead, targetPos.y, targetPos.z);

        }
        transform.position = targetPos;

    }
}
