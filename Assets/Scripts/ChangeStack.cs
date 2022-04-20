using UnityEngine;

public class ChangeStack : MonoBehaviour
{
    [SerializeField] private bool growStack;
    public void Change()
    {
        GameManager.Instance.ChangeStack(growStack);
    }
}
