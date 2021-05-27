using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingAI : MonoBehaviour
{
    public float move;

    public float PlayerRange;
    public bool playerInRange;
    public LayerMask PlayerLayer;
    public bool FacingAway;
    public GameObject bomb;
    public Transform dropPoint;
    private PlayerMovementScript ThePlayer;
    public bool FollowOnLockOn;
    float nextTimetoFire = 0;
    public float firerate;
    Vector2 Dir;
    public Transform target;
    bool therebePlayer = false;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        ThePlayer = FindObjectOfType<PlayerMovementScript>();
    }
    void Update()
    {
        Vector2 targetpos = target.position;
        Dir = targetpos - (Vector2)transform.position;
        RaycastHit2D rayInfo = Physics2D.Raycast(transform.position, Dir, PlayerRange);
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

            if (therebePlayer)
            {
                Vector2.MoveTowards(transform.position, target.position, Speed * Time.deltaTime);
                if (Time.time > nextTimetoFire)
                {
                    nextTimetoFire = Time.time + 1 / firerate;
                    DropBomb();
                }
            }
        }
    }
                void DropBomb()
                {
                    Instantiate(bomb, dropPoint.position, Quaternion.identity);
                }
                void OnDrawGizmosSelected()
                {
                    Gizmos.DrawWireSphere(transform.position, PlayerRange);

                }
            }
        

    


 
    

