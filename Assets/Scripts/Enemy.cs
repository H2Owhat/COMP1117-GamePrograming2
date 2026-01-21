using UnityEngine;

public class Enemy : Character
{
    [Header("Enemy Settings")]
    [SerializeField] private float patrolDistance;

    protected override void Awake()
    {
       base.Awake();
    }
}
