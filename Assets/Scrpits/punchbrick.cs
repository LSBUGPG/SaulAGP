using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punchbrick : MonoBehaviour
{
    public GameObject punchpoint;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            anim.SetBool("Kick", true);
            

        }
        if (Input.GetKeyUp("f"))
        {
  
            anim.SetBool("Kick", false);
        }
    }
            public void kickistrue()
    {
        punchpoint.SetActive(true);
    }

    public void kickisFalse()
    {
        punchpoint.SetActive(false);
    }
}

