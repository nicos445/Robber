using UnityEngine;

public class AutoTranslate : MonoBehaviour
{
    public Vector3 velocity { get; set; } = -Vector3.forward;

    void Update()
    {
        transform.Translate(velocity * Time.deltaTime);
    }
}
