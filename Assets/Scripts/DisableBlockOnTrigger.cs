using UnityEngine;

public class DisableBlockOnTrigger : MonoBehaviour
{
    [SerializeField] private Transform spawnPosition;
    public void Disable(Collider other)
    {
        other.transform.position = spawnPosition.position;
    }
}
