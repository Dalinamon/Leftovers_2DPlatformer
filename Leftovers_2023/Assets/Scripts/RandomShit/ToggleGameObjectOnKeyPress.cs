using UnityEngine;

public class ToggleGameObjectOnKeyPress : MonoBehaviour
{
    public GameObject objectToToggle;
    public KeyCode toggleKey = KeyCode.T;
    private bool isActive = true;

    private void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            isActive = !isActive;
            objectToToggle.SetActive(isActive);
        }
    }
}


