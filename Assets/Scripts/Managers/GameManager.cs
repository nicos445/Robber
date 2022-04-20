using UnityEngine;
using UnityEngine.SceneManagement;

//class handling parameters of the game
public class GameManager : MonoBehaviour
{
    [SerializeField] private UImanager uiManager;
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
    private bool hasWon = false;

    private const int DISTANCE_UNIT = 12;


    public float Speed
    {
        get
        {
            return speed;
        }
    }

    public Vector3 Velocity()
    {
        return speed * DISTANCE_UNIT * direction;
    }



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



    //Makes UI updating
    public void ChangeStack(bool increase)
    {
        diamondCounter++;
        uiManager.OnDiamond();

        robber.IncreaseOrDecreaseBag(increase);

        if (!increase)
        {
            cameraShake.Shake();
        }
    }


    public void EndGame(bool win)
    {
        characterSlideControls.enabled = false;
        hasWon = win;
        if (!win)
        {
            //Invoke("Invoke_EndCanvas", 0.5f);
            Invoke("Invoke_EndCanvas", 0);
        }
        else
        {
            Invoke_EndCanvas();
        }
    }

    private void Invoke_EndCanvas()
    {
        uiManager.EndGame(hasWon);
        Time.timeScale = 0;
    }

    //Reloads Game
    public void TRY_AGAIN()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
