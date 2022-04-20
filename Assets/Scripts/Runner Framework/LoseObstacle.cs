using UnityEngine;

public class LoseObstacle : MonoBehaviour
{
    public void Lose()
    {
        GameManager.Instance.EndGame();
    }
}
