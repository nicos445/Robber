using UnityEngine;
using UnityEngine.Events;

public class EventOnTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent<Collider> onTrigger;
    [SerializeField] private UnityTag triggerTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tags.TagToString(triggerTag)))
        {
            onTrigger.Invoke(other);
        }
    }
}
