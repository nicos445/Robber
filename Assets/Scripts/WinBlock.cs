using UnityEngine;

public class WinBlock : MonoBehaviour
{
    public void StopGame()
    {
        GameManager.Instance.EndGame(true);
    }
}
