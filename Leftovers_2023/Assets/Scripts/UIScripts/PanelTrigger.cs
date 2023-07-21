using UnityEngine;

public class PanelTrigger : MonoBehaviour
{
    public GameObject panel;

    private bool hasPlayerEntered;

    private void Start()
    {
        panel.SetActive(false); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hasPlayerEntered = true;
            panel.SetActive(true); 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hasPlayerEntered = false;
            panel.SetActive(false);
        }
    }

    private void Update()
    {
        if (hasPlayerEntered)
        {
            
        }
    }
}

