using System.Collections;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private float cameraShakeDuration = 0.5f;
    [SerializeField] private float cameraShakeDecreaseFactor = 1f;
    [SerializeField] private float cameraShakeAmount = 1f;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    public void Shake()
    {
        StartCoroutine(ShakeCamera());
    }

    IEnumerator ShakeCamera()
    {
        if (Time.timeScale == 0)
        {
            StopAllCoroutines();
            yield break;
        }

        Vector3 originalPos = mainCamera.transform.localPosition;
        float duration = cameraShakeDuration;
        while (duration > 0)
        {
            mainCamera.transform.localPosition = originalPos + Random.insideUnitSphere * cameraShakeAmount;
            duration -= Time.deltaTime * cameraShakeDecreaseFactor;
            yield return null;
        }
        mainCamera.transform.localPosition = originalPos;
    }
}
