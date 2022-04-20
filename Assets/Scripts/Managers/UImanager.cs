using UnityEngine;

public class UImanager : MonoBehaviour
{
    [SerializeField] private GameObject endCanvas;
    [SerializeField] private TMPro.TextMeshProUGUI diamondCounterText;

    public void SetDiamondCounter(int diamondCounter)
    {
        diamondCounterText.text = diamondCounter.ToString();
    }

    public void EndGame()
    {
        endCanvas.SetActive(true);
    }
}
