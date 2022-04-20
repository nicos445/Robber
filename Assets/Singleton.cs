using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance;


    public static Singleton Instance { get; private set; }

    void Awake()
    {

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

}
