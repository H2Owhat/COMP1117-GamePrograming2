using UnityEngine;

public class Enemy : Character
{
    [Header("Enemy Settings")]
    [SerializeField] private float patrolDistance = 5.0f;

    private Vector2 startPos;
    private int direction = -1;
    protected override void Awake()
    {
       base.Awake();
        startPos = transform.position;
    }

    private void Update()
    {
        //calculate boundries of my movement
        float leftBoundary = startPos.x - patrolDistance;//staring position - patrol distance
        float rightBoundary = startPos.x + patrolDistance;

        //move enemy
        transform.Translate(Vector2.right * direction * MoveSpeed * Time.deltaTime);

        //flip enemy when hits boundary
        if (transform.position.x >= rightBoundary)
        {
            direction = -1; // go to the left
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (transform.position.x <= leftBoundary)
        {
            direction = 1;
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
