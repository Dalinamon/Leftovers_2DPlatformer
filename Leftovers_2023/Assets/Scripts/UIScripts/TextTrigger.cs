using UnityEngine;
using UnityEngine.UI;

public class TextTrigger : MonoBehaviour
{
    public Text textToDisplay; 

    private bool hasPlayerEntered; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hasPlayerEntered = true;
            textToDisplay.gameObject.SetActive(true); 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            hasPlayerEntered = false;
            textToDisplay.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (hasPlayerEntered)
        {

        }
    }
}


