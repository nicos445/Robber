using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseObstacle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tags.Player))
        {
            GameManager.Instance.EndGame(false);
        }
    }
}
