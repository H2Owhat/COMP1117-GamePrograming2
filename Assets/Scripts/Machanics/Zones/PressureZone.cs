using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PressureZone : MonoBehaviour
{
    [SerializeField] private UnityEvent onActivated;
    public const string Key = "Key";
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == Key)
        {
            onActivated.Invoke();
        }
    }
}
