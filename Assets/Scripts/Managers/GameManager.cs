using UnityEngine;
using UnityEngine.SceneManagement;

//class handling parameters of the game
public class GameManager : MonoBehaviour
{
    [SerializeField] private UImanager uiManager;
    [SerializeField] private GameObject roadBlockPrefab;
    [SerializeField] private AutoTranslate autoTranslate;
    [SerializeField] private Robber robber;
    [SerializeField] private CharacterSlideControls characterSlideControls;
    [SerializeField] private CameraShake cameraShake;


    [Range(0f, 1.5f)]
    [SerializeField] private float speed;

    public static GameManager Instance => instance;
    private static GameManager instance;


    private Vector3 direction = -Vector3.forward;

    private int diamondCounter = 0;



    void Awake()
    {
        //singleton without DontDestroyOnLoad
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }

        instance = this;

        Application.targetFrameRate = 60;
        Time.timeScale = 0;
        autoTranslate.velocity = Velocity();
    }

    public Vector3 Velocity()
    {
        return speed * roadBlockPrefab.transform.localScale.z * direction;
    }


    public void ModifyStack(bool increase)
    {
        if (increase)
        {
            diamondCounter++;
        }
        else
        {
            diamondCounter /= 2;
        }

        uiManager.SetDiamondCounter(diamondCounter);

        robber.IncreaseOrDecreaseBag(increase, diamondCounter);

        if (!increase)
        {
            cameraShake.Shake();
        }
    }


    public void EndGame()
    {
        characterSlideControls.enabled = false;
        uiManager.EndGame();
        Time.timeScale = 0;
    }

    //Reloads Game
    public void TRY_AGAIN()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
