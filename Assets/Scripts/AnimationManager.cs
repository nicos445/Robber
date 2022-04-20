using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    public void PlayAnimation()
    {
        anim.Play();
    }

    public void RewindAnim()
    {
        anim.Rewind();
        anim.Play();
        anim.Sample();
        anim.Stop();
    }
}
