using UnityEngine;

public class ChangeStack : MonoBehaviour
{
    [SerializeField] private bool growStack;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Change()
    {
        audioSource.Play();
        GameManager.Instance.ChangeStack(growStack);
    }
}
