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

    //Starts by getting the Rigidbody2D and animator components
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    //If the player is on tghe ground, they will be able to jump and the correct animation will play
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

    //The bool of being grounded, therefore declaring the player is on the ground, is set to true when colliding with the ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            isGrounded = true;
        }
    }
}
