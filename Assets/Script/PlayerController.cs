using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Movement components
    private CharacterController controller;
    private Animator animator;

    public float moveSpeed = 4f;
    
    public float falldown = -4f;

    [Header("Movement System")]
    public float runSpeed = 8f;
    public float walkSpeed = 4f;

    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        // Get Movement components
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move()
    {
        //Get horizonal & vertical as a number
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

       
        //Direction in a normalised vector
        Vector3 dir = new Vector3(horizontal, 0f, vertical).normalized;
        //Vector3 velocity = moveSpeed * Time.deltaTime * dir;

        //Is the sprint key pressed
        if (Input.GetButton("Sprint"))
        {
            // Set the animation to run
            moveSpeed = runSpeed;
            animator.SetBool("Running", true);
        }
        else
        {
            // Set the animation to walk
            moveSpeed = walkSpeed;
            animator.SetBool("Running", false);

        }

        //Check if there is movement
        //if (dir.magnitude >= .1f)
        //{
        //    //Look towards that direction
        //    transform.rotation = Quaternion.LookRotation(dir);

        //    //Move
        //    controller.Move(velocity);

        //}

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(move * moveSpeed * Time.deltaTime);

        
        velocity.y += falldown * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        animator.SetFloat("Speed", dir.magnitude);
    }
}
