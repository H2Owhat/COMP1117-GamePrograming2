using UnityEngine;

public class NPCLogic : MonoBehaviour, Iinteractable
{
    [SerializeField] private GameObject speechBubble;
    public void Interact()
    {
        if (speechBubble == null)
        {
            return;
        }

        bool isCurrentlyActive = speechBubble.activeSelf;
        speechBubble.SetActive(!isCurrentlyActive);

    }
}
