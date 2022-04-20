using UnityEngine;

public class Collectible : RoadElement
{
    [SerializeField] private GameObject particles;
    [SerializeField] private GameObject mRenderer;


    public void Collect()
    {
        Activate(false);
    }

    public override void Reset()
    {
        base.Reset();
        Activate(true);
    }

    private void Activate(bool collect)
    {
        mRenderer.SetActive(collect);
        particles.SetActive(!collect);
    }
}
