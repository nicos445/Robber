using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    [SerializeField] private GameObject particles;
    [SerializeField] private GameObject mRenderer;
    public void Collect()
    {
        mRenderer.SetActive(false);
        particles.SetActive(true);
    }
}
