using UnityEngine;
using UnityEngine.SceneManagement;

public class StartCredits : MonoBehaviour
{
    public ScrollCredits scrollCredits;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "YourCreditSceneName")
        {
            scrollCredits.StartScrolling();
        }
    }
}

