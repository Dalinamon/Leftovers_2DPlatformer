using UnityEngine;

public class PanelTriggerSimplified : MonoBehaviour
{
    public GameObject panel; // Reference to the panel GameObject in the canvas

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            panel.SetActive(true); // Open the panel by enabling its GameObject
            Debug.Log("Panel opened");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            panel.SetActive(false); // Close the panel by disabling its GameObject
            Debug.Log("Panel closed");
        }
    }
}