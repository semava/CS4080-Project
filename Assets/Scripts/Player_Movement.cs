using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Movement : MonoBehaviour
{
    public Animator animator;
    public Transform camera;
    public ContactFilter2D movementFilter;
    public float moveSpeed = 1000f;
  
    private Vector2 moveInput;
    private Rigidbody2D rb;
    private List<RaycastHit2D> castCollisions = new List<RaycastHit2D>();

    // Start is called before the first frame update
    void Awake()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0 && Input.GetAxis("Vertical") != 0)
        {
            animator.SetFloat("Horizontal", 0.0f);
        }
        else
        {
            animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        }
        animator.SetFloat("Vertical", Input.GetAxis("Vertical"));

       

        bool success = MovePlayer(moveInput);

        if (!success)
        {
            success = MovePlayer(new Vector2(moveInput.x, 0));
            if (!success)
            {
                success = MovePlayer(new Vector2(0, moveInput.y));
            }
        }

        camera.position = new Vector3(transform.position.x, transform.position.y, -10);
    }


    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public bool MovePlayer(Vector2 direction)
    {
 
        //Checks for potential collisions
        int count = rb.Cast(direction, movementFilter, castCollisions, moveSpeed * Time.fixedDeltaTime);

        if (count == 0)
        {
            Vector2 moveVector = direction * moveSpeed * Time.fixedDeltaTime;

            rb.MovePosition(rb.position + moveVector);
            return true;
        }
        else
        {
            return false;
        }
    }
}
