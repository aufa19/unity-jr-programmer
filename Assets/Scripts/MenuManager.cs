using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public bool isPaused { get; private set; } = false;
    public bool isInventory { get; private set; } = false;

    [SerializeField]
    private GameObject inventoryMenu, pauseMenu;

    [SerializeField]
    PausableInputHandler inventoryKeyHandler, playerMovement;

    public void OpenInventory()
    {
        isInventory = true;
        RenderState();
    }

    public void CloseInventory()
    {
        isInventory = false;
        RenderState();
    }

    public void OpenPause()
    {
        isPaused = true;
        RenderState();
    }

    public void ClosePause()
    {
        isPaused = false;
        RenderState();
    }

    private void RenderState()
    {
        if (isPaused)
        {
            inventoryKeyHandler.isPaused = true;
            playerMovement.isPaused = true;
            inventoryMenu.SetActive(false);
            pauseMenu.SetActive(true);
        }
        else
        {
            if (isInventory)
            {
                inventoryKeyHandler.isPaused = false;
                playerMovement.isPaused = true;
                inventoryMenu.SetActive(true);
                pauseMenu.SetActive(false);
            }
            else
            {
                inventoryKeyHandler.isPaused = false;
                playerMovement.isPaused = false;
                inventoryMenu.SetActive(false);
                pauseMenu.SetActive(false);
            }
        }
    }

}
