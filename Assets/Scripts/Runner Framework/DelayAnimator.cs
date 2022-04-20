using System.Collections;
using UnityEngine;

public class DelayAnimator : MonoBehaviour
{
    [SerializeField] private float delay = 0;

    private Animator animator;
    IEnumerator Start()
    {
        animator = GetComponent<Animator>();
        yield return new WaitForSeconds(delay);
        animator.enabled = true;
    }
}
