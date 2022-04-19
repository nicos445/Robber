using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    [SerializeField] private GameObject particles;
    [SerializeField] private GameObject mRenderer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tags.Player))
        {
            mRenderer.SetActive(false);
            particles.SetActive(true);
            //Destroy(gameObject);
        }
    }
}
