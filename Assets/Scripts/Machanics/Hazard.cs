using UnityEngine;

public class Hazard : MonoBehaviour
{
    [SerializeField] private Player playerController;
    [SerializeField] private int damageToDeal = 100;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (playerController != null)
        {
            playerController.TakeDamage(damageToDeal);
            Debug.Log("attacking the player");
        }
        else
        {
            Debug.Log("TESTENEMY.cs: Player is null");
        }
    }
}
