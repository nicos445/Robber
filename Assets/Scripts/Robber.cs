using UnityEngine;

public class Robber : MonoBehaviour
{
    [SerializeField] private Transform bag;
    [SerializeField] private Animation hitAnimation;
    [SerializeField] private Animation bagHitAnimation;
    [SerializeField] private Animation loseHitAnimation;

    private Vector3 scaleAtStart;

    void Start()
    {
        scaleAtStart = bag.localScale;
    }

    public void IncreaseOrDecreaseBag(bool increase, int nbDiamonds)
    {
        if (!increase)
        {
            GetHit();
        }

        bag.localScale = scaleAtStart * (1 + nbDiamonds * 0.08f);
    }

    private void GetHit()
    {
        hitAnimation.Play();
        bagHitAnimation.Play();
        loseHitAnimation.transform.position = bagHitAnimation.transform.position;
        loseHitAnimation.Play();
    }
}
