using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseObstacle : MonoBehaviour
{
    public void Lose()
    {
        GameManager.Instance.EndGame(false);
    }
}
