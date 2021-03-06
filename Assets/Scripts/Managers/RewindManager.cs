using UnityEngine;

public class RewindManager : MonoBehaviour
{
    [SerializeField] Transform level;

    private AnimationManager[] animationManagers;
    private RoadElement[] roadElements;

    private void Start()
    {
        animationManagers = level.GetComponentsInChildren<AnimationManager>();
        roadElements = level.GetComponentsInChildren<RoadElement>();
    }

    public void Rewind()
    {
        foreach (AnimationManager animationManager in animationManagers)
        {
            animationManager.Rewind();
        }

        foreach (RoadElement roadElement in roadElements)
        {
            roadElement.Reset();
        }
    }
}
