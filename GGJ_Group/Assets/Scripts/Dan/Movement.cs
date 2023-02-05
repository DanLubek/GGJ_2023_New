using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed;

    float vertIn, horzIn;
    Vector3 forward, right, forwardRelativeVertIn, rightRelativeHorzIn, cameraRelativeMovement;
    Animator animator;
    Rigidbody rb;

    bool pressedJump, canJump, jumpWasPressed;

    int clamp;

    public AudioSource jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 10f;
        canJump = true;
        jumpWasPressed = false;
        clamp = 5;
        Cursor.lockState = CursorLockMode.Locked;
        animator = GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {        
        MovePlayer();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) pressedJump = true;

        if (rb.velocity.y < 0f)
        {
            rb.velocity += Vector3.up * (Physics.gravity.y * 3f) * Time.deltaTime;
        }
    }

    void MovePlayer()
    {     
        vertIn = Input.GetAxis("Vertical");
        horzIn = Input.GetAxis("Horizontal");
        

        forward = transform.InverseTransformDirection(Camera.main.transform.forward).normalized;
        right = transform.InverseTransformDirection(Camera.main.transform.right).normalized;


        forward.y = 0;
        right.y = 0;


        forward = forward.normalized;
        right = right.normalized;


        forwardRelativeVertIn = vertIn * forward;
        rightRelativeHorzIn = horzIn * right;


        cameraRelativeMovement = forwardRelativeVertIn + rightRelativeHorzIn;


        if (pressedJump && canJump)
        {
            jump.Play();
            animator.SetBool("isJumping", true);
            pressedJump = false;
            cameraRelativeMovement = new Vector3(cameraRelativeMovement.x, 50, cameraRelativeMovement.z);
            rb.AddRelativeForce(cameraRelativeMovement, ForceMode.VelocityChange);
            clamp = 8;
        }
        else
            
            rb.AddRelativeForce(cameraRelativeMovement, ForceMode.VelocityChange);
        
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, clamp);        


        if (new Vector3(horzIn, 0, vertIn) == Vector3.zero)
        {
            return;
        }


        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(Camera.main.transform.forward.x, 0, Camera.main.transform.forward.z)), 10f * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(JumpDelay());        
    }

    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
    }

    IEnumerator JumpDelay()
    {
        clamp = 5;
        yield return new WaitForSeconds(0.2f);
        pressedJump = false;
        canJump = true;
    }
}
