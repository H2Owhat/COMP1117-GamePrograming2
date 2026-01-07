using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerStats stats;

    
    //components
    private Rigidbody2D rBody;

    //field variables
    private Vector2 moveInput;
    

     void Awake()
    {
        //initilize
        rBody = GetComponent<Rigidbody2D>();
        stats = new PlayerStats();
       int something stats.MoveSpeed = 100;
    }

     void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        ApplyMovement(); 
    }

    void ApplyMovement()
    {
        float velocityx = moveInput.x; 
        rBody.linearVelocity = new Vector2 (velocityx , rBody.linearVelocity.y);
    }
}
