using UnityEngine;

public class TextOpening : MonoBehaviour
{
    public GameObject objectToActivate;
    public float activateDelay = 4f;
    public float deactivateDelay = 5f;
    private bool isActivated = false;
    private float timer = 0f;
    private bool isDeactivatedForever = false;

    private void Update()
    {
        if (!isActivated && !isDeactivatedForever)
        {
            timer += Time.deltaTime;

            if (timer >= activateDelay)
            {
                objectToActivate.SetActive(true);
                isActivated = true;
                timer = 0f; 
            }
        }
        else if (isActivated && !isDeactivatedForever)
        {
            timer += Time.deltaTime;

            if (timer >= deactivateDelay)
            {
                objectToActivate.SetActive(false);
                isDeactivatedForever = true;
            }
        }
    }
}
