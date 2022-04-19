using UnityEngine;

//Waits for first touch to begin the run
public class WaitForTap : MonoBehaviour
{
    [SerializeField] private GameObject gameCanvas;

    // Update is called once per frame
    void Update()
    {
        if ((Input.touchCount == 1 || Input.GetMouseButton(0)))
        {
            Time.timeScale = 1;
            gameObject.SetActive(false);
            gameCanvas.SetActive(true);
        }
    }
}
