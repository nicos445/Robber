using UnityEngine;

public class PutBlockAtTheEndOfRoad : MonoBehaviour
{
    [SerializeField] private Transform lastBlock;
    public void Disable(Collider other)
    {
        other.transform.position = lastBlock.position + Vector3.forward * lastBlock.localScale.z * 1f;
        lastBlock = other.transform;
    }
}
