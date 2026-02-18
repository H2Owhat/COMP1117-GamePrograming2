using UnityEngine;

public class TresureChest : MonoBehaviour, Iinteractable
{
    [Header("loot Settings")]
    [SerializeField] private GameObject gemPrefab;
    [SerializeField] private int gemCount = 3;
    [SerializeField] private float launchForce = 5f;

    [Header("visuals")]
    [SerializeField] private Sprite openChestSprite;

    private SpriteRenderer sRend;
    private bool isOpened = false;

    private void Awake()
    {
        sRend = GetComponent<SpriteRenderer>();
    }

    public void Interact()
    {
        if (isOpened)
        {
            return;
        }

        isOpened = true;
        openChest();
    }

    private void openChest()
    {
        if(sRend != null && openChestSprite != null)
        {
            sRend.sprite = openChestSprite;
        }

        for(int i= 0; i < gemCount; i++)
        {
            GameObject gem = Instantiate(gemPrefab, transform.position, Quaternion.identity);
            Rigidbody2D gemRB = gem.GetComponent<Rigidbody2D>();

            if (gemRB != null)
            {
                Vector2 force = new Vector2(Random.Range(-1f, 1f),1.5f).normalized *launchForce;
                gemRB.AddForce(force, ForceMode2D.Impulse);
                
            }
        }
    }
}
