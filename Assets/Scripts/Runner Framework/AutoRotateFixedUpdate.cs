using UnityEngine;

public class AutoRotateFixedUpdate : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;


    void FixedUpdate()
    {
        transform.Rotate(velocity);
    }
}
