using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextTrigger : MonoBehaviour
{
    public Text notificationText;
    public float textDisplayDuration = 2.0f; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            notificationText.gameObject.SetActive(true);
            notificationText.text = "Level Completed"; 

            
            StartCoroutine(HideTextAfterDelay());
        }
    }

    private IEnumerator HideTextAfterDelay()
    {
        yield return new WaitForSeconds(textDisplayDuration);
        notificationText.gameObject.SetActive(false);
    }
}
