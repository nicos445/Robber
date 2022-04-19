using UnityEngine;

public class DisableBlockOnTrigger : MonoBehaviour
{
    [SerializeField] private Transform spawnPosition;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tags.roadBlock))
        {
            other.transform.position = spawnPosition.position;
        }
    }
}
