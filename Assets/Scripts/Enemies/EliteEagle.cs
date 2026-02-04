using UnityEngine;

public class EliteEagle : Enemy
{
    private SpriteRenderer sRender;
    

    protected override void Awake()
    {
        sRender = GetComponent<SpriteRenderer>();
            base.Awake();
        ChangeColour();
       
    }
   
    private void Update()
    {
       

        //calculate boundries of my movement
        float leftBoundary = startPos.x - patrolDistance;//staring position - patrol distance
        float rightBoundary = startPos.x + patrolDistance;

        //move enemy
        transform.Translate(Vector2.right * direction * MoveSpeed*(2) * Time.deltaTime);

        //flip enemy when hits boundary
        if (transform.position.x >= rightBoundary)
        {
            direction = -1; // go to the left
            transform.localScale = new Vector3(2, 2, 2);
        }
        else if (transform.position.x <= leftBoundary)
        {
            direction = 1;
            transform.localScale = new Vector3(-2, 2, 2);
        }
    }

    void ChangeColour()
    {
        sRender.color = new Color(1, 1, 0, 1);
    }

   


}
