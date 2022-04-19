using UnityEngine;

public class ChangeStack : MonoBehaviour
{
    [SerializeField] private bool growStack;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tags.Player))
        {
            GameManager.Instance.ChangeStack(growStack);
        }
    }
}
