using UnityEngine;

public class PanelTriggerSimplified : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            panel.SetActive(true); 
            Debug.Log("Panel opened");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            panel.SetActive(false); 
            Debug.Log("Panel closed");
        }
    }
}