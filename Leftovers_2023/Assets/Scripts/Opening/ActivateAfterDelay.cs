using UnityEngine;

public class ActivateAfterDelay : MonoBehaviour
{
    public GameObject objectToActivate;
    public float delay = 4f;
    private bool isActivated = false;
    private float timer = 0f;

    private void Update()
    {
        if (!isActivated)
        {
            timer += Time.deltaTime;

            if (timer >= delay)
            {
                objectToActivate.SetActive(true);
                isActivated = true;
            }
        }
    }
}
