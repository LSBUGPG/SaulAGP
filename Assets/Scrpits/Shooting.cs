using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public int BulletCount;
    public GameObject bullet;
    public Transform firepoint;
    private Animator anim;
    // Start is called before the first frame update

     void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet = Instantiate(bullet, firepoint.position, firepoint.rotation);
    
            BulletCount -= 1;

            Destroy(newBullet,1f);

        }

        if (BulletCount == 0)
        {
            enabled = false;

        }
    }
}