using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Gem : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 1.5f;

    private void FixedUpdate()
    {
        StartCoroutine(ToPlayer());
    }
    public IEnumerator ToPlayer()
    {
        yield return new WaitForSeconds(2f);
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
