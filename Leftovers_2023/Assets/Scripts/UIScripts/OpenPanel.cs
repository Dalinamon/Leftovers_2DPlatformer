using UnityEngine;

public class OpenPanel: MonoBehaviour
{
    public GameObject panel;
    private bool isPanelOpen = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPanelOpen)
            {
                ClosePanel();
            }
            else
            {
                PanelOpen();
            }
        }
    }

    private void PanelOpen()
    {
        panel.SetActive(true);
        isPanelOpen = true;
    }

    private void ClosePanel()
    {
        panel.SetActive(false);
        isPanelOpen = false;
    }
}

