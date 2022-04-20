using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayAnimator : MonoBehaviour
{
    [SerializeField] private float delay = 0;
    /*[SerializeField]*/
    private Animator animator;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        animator = GetComponent<Animator>();
        yield return new WaitForSeconds(delay);
        animator.enabled = true;
    }
}
