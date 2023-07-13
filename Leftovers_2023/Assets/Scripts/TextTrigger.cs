using UnityEngine;
using UnityEngine.UI;

public class TextTrigger : MonoBehaviour
{
    public Text textToDisplay; // Reference to the text component on the canvas

    private bool hasPlayerEntered; // Flag to check if the player has entered the trigger

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hasPlayerEntered = true;
            textToDisplay.gameObject.SetActive(true); // Enable the text component on the canvas
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hasPlayerEntered = false;
            textToDisplay.gameObject.SetActive(false); // Disable the text component on the canvas
        }
    }

    private void Update()
    {
        if (hasPlayerEntered)
        {
            // You can update the text content here if needed
            // Example: textToDisplay.text = "Hello, player!";
        }
    }
}


