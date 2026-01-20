using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    // inital player stats 

    [SerializeField] private float initalSpeed = 5;
    [SerializeField] private int initalHealth = 100;

    //private variables
    private PlayerStats stats;
    private Vector2 moveInput;
    private bool isDead = false;

    //components
    private Rigidbody2D rBody;

   
   
    

     void Awake()
    {
        //initilize
        rBody = GetComponent<Rigidbody2D>();

        stats = new PlayerStats(initalSpeed, initalHealth);
       
      
    }

     void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        ApplyMovement(); 
    }

    private void ApplyMovement()
    {
        float velocityx = moveInput.x * stats.MoveSpeed; 
        rBody.linearVelocity = new Vector2 (velocityx , rBody.linearVelocity.y);
    }

    public void TakeDamage(int DamageAmount)
    {
        stats.CurrentHealth -= DamageAmount;

        Debug.Log("player took damage");

        if (stats.CurrentHealth == 0)
        {
            isDead = true;

            if (isDead = true)
            {
                Debug.Log("player is dead");
            }
        }
        else
        {
             isDead = false;
        }

        
    }
}
