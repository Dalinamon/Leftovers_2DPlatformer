using UnityEngine;

public class ScrollCredits : MonoBehaviour
{
    public RectTransform creditsContent;
    public float scrollSpeed = 20f;

    private bool scrolling = false;

    private void Start()
    {
        StartScrolling();
    }

    public void StartScrolling()
    {
        scrolling = true;
    }

    public void StopScrolling()
    {
        scrolling = false;
    }

    private void Update()
    {
        if (scrolling)
        {
            Vector2 position = creditsContent.anchoredPosition;
            position.y += scrollSpeed * Time.deltaTime;
            creditsContent.anchoredPosition = position;

            if (position.y >= creditsContent.rect.height)
            {
                StopScrolling();
            }
        }
    }
}
