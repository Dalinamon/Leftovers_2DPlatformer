/*
using System.Collections;
using UnityEngine;

public class ScreenShakeEffect : MonoBehaviour
{
    private Transform mainCamera;
    private Vector3 originalCameraPosition;

    public float shakeDuration = 0.5f;
    public float shakeMagnitude = 0.1f;

    private bool isShaking = false;

    private void Start()
    {
        mainCamera = Camera.main.transform;
    }

    public void Shake()
    {
        if (!isShaking)
        {
            originalCameraPosition = mainCamera.localPosition;
            StartCoroutine(ShakeCoroutine());
        }
    }

    public void StopShake()
    {
        StopAllCoroutines();
        mainCamera.localPosition = originalCameraPosition;
        isShaking = false;
    }

    private IEnumerator ShakeCoroutine()
    {
        isShaking = true;
        float elapsedTime = 0;

        while (elapsedTime < shakeDuration)
        {
            Vector3 randomOffset = Random.insideUnitSphere * shakeMagnitude;
            mainCamera.localPosition = originalCameraPosition + randomOffset;

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        mainCamera.localPosition = originalCameraPosition;
        isShaking = false;
    }
}
*/