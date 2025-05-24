using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;

    private float jumpPower = 7;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform feetPos;
    private float groundDistance = 0.3f;
    private float jumpTime = 0.3f;
    private bool isGrounded = false;
    private bool isJumping = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, groundDistance, groundLayer);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            animator.SetBool("isJumping", true);
            isJumping = true;
            rb.velocity = Vector2.up * jumpPower;
            isGrounded = false;
        }

        if(isGrounded == true)
        {
            isJumping = false;
            animator.SetBool("isJumping", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            isGrounded = true;
        }
    }
}
