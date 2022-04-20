using UnityEngine;

public class RoadManager : MonoBehaviour
{
    [SerializeField] private int i = -1;
    [SerializeField] Transform level;
    [SerializeField] Transform roadBlocks;
    private AnimationManager[] animationManagers;
    private Collectible[] collectibles;
    private const float BLOCK_LENGTH = 12f;
    private int iAtStart;
    private float zAtStart;

    private void Start()
    {
        iAtStart = i;
        zAtStart = transform.localPosition.z;
        animationManagers = level.GetComponentsInChildren<AnimationManager>();
        collectibles = level.GetComponentsInChildren<Collectible>();
    }

    public void Rewind()
    {
        foreach (AnimationManager animationManager in animationManagers)
        {
            animationManager.RewindAnim();
        }

        foreach (Collectible collectible in collectibles)
        {
            collectible.Reset();
        }

        //foreach (Transform block in roadBlocks)
        //{
        //    block.gameObject.SetActive(true);
        //    // block.localPosition = new Vector3(0, 0, i++ * BLOCK_LENGTH);
        //}

        // transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, zAtStart);
        i = iAtStart;
    }
}
