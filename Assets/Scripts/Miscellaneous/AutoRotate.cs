using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    [SerializeField] private Vector3 velocity;



    void FixedUpdate()
    {
        transform.Rotate(velocity);
    }
}
