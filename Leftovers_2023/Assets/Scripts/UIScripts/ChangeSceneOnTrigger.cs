using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnTrigger : MonoBehaviour
{
    public string sceneToLoad; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger collision detected with Player.");
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}