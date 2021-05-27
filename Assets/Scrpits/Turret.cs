using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    public float Range;
    public GameObject Gun;
    public Transform target;
    public GameObject bullet;
    bool therebePlayer = false;
    public float firerate;
    float nextTimetoFire = 0;
    Vector2 Dir;
    public Transform shootpoint;
    public float force;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 targetpos = target.position;
        Dir = targetpos - (Vector2)transform.position;
        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Dir, Range);

        if (rayInfo)
        {
            if (rayInfo.collider.gameObject.tag == "Player")
            {
                if (therebePlayer == false)
                {
                    therebePlayer = true;
                }

                else
                {
                    if (therebePlayer == true)
                    {
                        therebePlayer = false;
                    }
                }
            }
            if (therebePlayer )
            {

     
                if(Time.time > nextTimetoFire)
                {
                    nextTimetoFire = Time.time + 1 / firerate;
                    Shoot();
                }

            }
        }
    }
            void Shoot()
            {
              Instantiate(bullet, shootpoint.position, Quaternion.identity);

            }
           
            void OnDrawGizmosSelected()
            {
                Gizmos.DrawWireSphere(transform.position, Range);

            }
        }
    


    