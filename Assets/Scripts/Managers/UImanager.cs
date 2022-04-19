using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    [SerializeField] private GameObject endCanvas;
    [SerializeField] private GameObject winText;
    [SerializeField] private GameObject loseText;
    [SerializeField] private Image progressionImage;

    private int diamondCounter = 0;

    private void Start()
    {
    }

    //Shows the game progression
    public void OnDiamond()
    {
        diamondCounter++;
        // progressionImage.fillAmount = (float) diamondCounter / (float) diamondGoal;
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
