using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyAI : MonoBehaviour
{



    public GameObject furballPrefab;
    public GameObject Explosion;
    public Transform Player;
    public Transform player;
    public float knockbackspeed;



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(furballPrefab, transform.position, Quaternion.identity);
           
            Instantiate(Explosion, Player.position, Quaternion.identity);



           

        }
    }


}















