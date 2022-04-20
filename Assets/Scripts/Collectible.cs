using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private GameObject particles;
    [SerializeField] private GameObject mRenderer;

    private Vector3 positionAtStart;

    private void Start()
    {
        positionAtStart = transform.position;
    }
    public void Collect()
    {
        Activate(false);
    }

    public void Reset()
    {
        Activate(true);
        transform.position = positionAtStart;
    }

    private void Activate(bool collect)
    {
        mRenderer.SetActive(collect);
        particles.SetActive(!collect);
    }
}
