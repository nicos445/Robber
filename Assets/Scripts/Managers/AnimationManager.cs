using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    private Animation anim;
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    public void Play()
    {
        anim.Play();
    }

    public void Rewind()
    {
        anim.Rewind();
        anim.Play();
        anim.Sample();
        anim.Stop();
    }
}
