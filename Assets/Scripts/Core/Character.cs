using System.Runtime.CompilerServices;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class Character : MonoBehaviour
{
    //private variables
    [Header("Character Stats")]
    [SerializeField] private float moveSpeed = 5.0f;
    [SerializeField] private int maxHealth = 100;

    private int currentHealth;

    private bool isDead = false;
    protected Animator anim;

    //public properties
    public float MoveSpeed
    {
        //read-only 
        get { return moveSpeed; }
    }

    public bool IsDead
    {
        //read-only
        get { return isDead; }
    }

    protected int CurrentHealth
    {
        get { return currentHealth; }
        set { currentHealth = Mathf.Clamp(value, 0, maxHealth); }
    }


  


    protected virtual void Awake()
    {
        anim = GetComponent<Animator>();
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        //level of protection
        if (IsDead)
        {
            return;
        }

        CurrentHealth -= amount;
        Debug.Log($"{gameObject.name} HP is now: {CurrentHealth}");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected void Die()
    { 
        isDead = true;
        Debug.Log($"{gameObject.name} has died");
    }
}
