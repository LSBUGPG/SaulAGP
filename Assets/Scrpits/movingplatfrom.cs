using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatfrom : MonoBehaviour
{
    public GameObject objecttomove;

    public Transform startPoint;
    public Transform endPoint;
    public float movespeed;
    private Vector3 currenttarget;

     void Start()
    {
        currenttarget = endPoint.position;
    }

     void Update()
    {
        objecttomove.transform.position = Vector3.MoveTowards(objecttomove.transform.position, currenttarget, movespeed * Time.deltaTime);

        if (objecttomove.transform.position == endPoint.position)
        {
            currenttarget = startPoint.position;
        }
        if (objecttomove.transform.position == startPoint.position)
        {
            currenttarget = endPoint.position;
        }
        }
    }

