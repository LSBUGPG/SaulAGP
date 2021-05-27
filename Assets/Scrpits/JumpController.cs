using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpController : MonoBehaviour
{
    private Animator anim;
    [Range(1, 10)]
    public float jumpvelocity;
    public Transform groundCheck;
    public float groundCheckradius;
    public LayerMask whatisground;
    public bool isgrounded;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        isgrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckradius, whatisground);
        if (Input.GetButtonDown("Jump") && isgrounded)
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpvelocity;
            anim.SetBool("Grounded", true);
        }
        if (Input.GetButtonUp("Jump"))
        {
            anim.SetBool("Grounded", false);

        }

    }
}






















