using UnityEngine;

public class PauseKeyHandler : MonoBehaviour
{
    [SerializeField] private MenuManager menuManager;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuManager.isPaused)
            {
                menuManager.ClosePause();
            }
            else
            {
                menuManager.OpenPause();
            }
        }
    }
}
