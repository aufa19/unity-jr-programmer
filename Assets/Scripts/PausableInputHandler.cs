using UnityEngine;

public abstract class PausableInputHandler : MonoBehaviour
{
    public bool isPaused = false;

    protected void Update()
    {
        if (!isPaused)
        {
            HandleInput();
        }
        else
        {
            HandlePauseInInput();
        }
    }

    protected abstract void HandleInput();

    protected virtual void HandlePauseInInput() { }
}
