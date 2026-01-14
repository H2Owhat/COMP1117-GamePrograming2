using UnityEngine;
using UnityEngine.InputSystem;

public class TestEnemy : MonoBehaviour
{
    //unitys recommendation
    [SerializeField] private PlayerController playerController;
    [SerializeField] private int damageToDeal = 15;

    public void OnAttack(InputValue value)
    {
        if(value.isPressed)
        {
            if (playerController != null)
            {
                playerController.TakeDamage(damageToDeal);
                Debug.Log("attacking the player");
            }
            else
            {
                Debug.Log("TESTENEMY.cs: PlayerController is null");
            }
        }
    }
}
