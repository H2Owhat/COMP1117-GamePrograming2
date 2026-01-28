using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(PlayerInputHandler), typeof(Rigidbody2D))]
public class Player : Character
{
    //jumping logic
    [Header("Movement Settings")]
    [SerializeField] private float jumpForce = 12;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius;


    //components
    private Rigidbody2D rBody;
    private PlayerInputHandler input;
    private bool isGrounded;


     protected override void Awake()
    {
        base.Awake();
        //initilize
        rBody = GetComponent<Rigidbody2D>();
        input = GetComponent<PlayerInputHandler>();
    }

    private void Update()
    {
        //preform ground check 
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        anim.SetFloat("xVelocity", Mathf.Abs(rBody.linearVelocity.x));
        anim.SetBool("isGrounded", isGrounded);
        anim.SetFloat("yVelocity", rBody.linearVelocity.y);

        //handle sprite flipping
        if(input.MoveInput.x !=0)
        {
            transform.localScale = new Vector3(Mathf.Sign(input.MoveInput.x), 1, 1);
        }
    }

    private void FixedUpdate()
    {
        if (IsDead)
        {
            return;
        }
        HandleMovement();
        HandleJump();
    }

    private void HandleMovement()
    {
        float horizontalVelocity = input.MoveInput.x * MoveSpeed;

        rBody.linearVelocity = new Vector2(horizontalVelocity, rBody.linearVelocity.y);
    }
    private void HandleJump()
    {
        if (input.JumpTriggered && isGrounded)
        {
            ApplyJumpForce();
        }
    }

    private void ApplyJumpForce()
    {
        rBody.linearVelocity = new Vector2(rBody.linearVelocity.x, 0);
        
        rBody.AddForce(Vector2.up *jumpForce, ForceMode2D.Impulse);
    }

    
}
