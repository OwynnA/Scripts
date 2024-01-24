using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharController : MonoBehaviour
{
    //I got some of this code from the character controller page in the canvas class
    //the rest came from a game I made last year
    public float moveSpeed;
    public float jumpForce;
    public float gravity = -20f;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;

    Animator animator;
    //public TextMeshProUGUI gameOver;
    //public GameObject damage;

    //private SoundManager sound;

    private void Awake()
    {
        //sound = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        //damage = GameObject.FindGameObjectWithTag("damage");
    }

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, 0.1f, groundLayer);

        // Horizontal movement
        float moveInputX = Input.GetAxis("Vertical");
        Vector3 moveDirection = new Vector3(0, 0, moveInputX);
        Vector3 move = transform.TransformDirection(moveDirection) * moveSpeed;
        if(moveInputX != 0)
        {
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }

        // Apply gravity
        if (!isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
            animator.SetBool("Run", false);
        }
        else
        {
            velocity.y = 0;
            animator.SetTrigger("Jump End");
        }

        // Jumping
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            //sound.JumpSFX();
            velocity.y = Mathf.Sqrt(jumpForce * -2 * gravity);
            animator.SetTrigger("Jump");
        }

        // Apply movement and gravity
        controller.Move((move + velocity) * Time.deltaTime);
    }

    /*public void Die()
    {
        sound.DeathSFX();
        animator.SetTrigger("Death");
        gameOver.gameObject.SetActive(true);
        gameOver.text = "Game Over";
        Debug.Log("If nothing happened something's wrong");
    }*/
}