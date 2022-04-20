using UnityEngine;

public class UImanager : MonoBehaviour
{
    [SerializeField] private GameObject endCanvas;
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject loseText;
    [SerializeField] private TMPro.TextMeshProUGUI diamondCounterText;


    //Shows the game progression
    public void SetDiamondCounter(int diamondCounter)
    {
        diamondCounterText.text = diamondCounter.ToString();
    }

    //Adapts text according to win state
    public void EndGame(bool win)
    {
        endCanvas.SetActive(true);
        if (win)
        {
            winText.SetActive(true);
        }

        else
        {
            loseText.SetActive(true);
        }
    }

}
