using UnityEngine;

public class RoadElement : MonoBehaviour
{
    private Vector3 positionAtStart;
    void Start()
    {
        positionAtStart = transform.position;
    }

    public virtual void Reset()
    {
        transform.position = positionAtStart;
    }
}
