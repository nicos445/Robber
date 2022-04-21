using UnityEngine;

public class AutoUnparent : MonoBehaviour
{
    void Awake()
    {
        transform.SetParent(null);
    }
}
