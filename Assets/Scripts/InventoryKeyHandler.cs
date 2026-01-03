using UnityEngine;

// INHERITANCE
public class InventoryKeyHandler : PausableInputHandler
{
    [SerializeField] private MenuManager menuManager;

    // POLYMORPHISM
    protected override void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (menuManager.isInventory)
            {
                menuManager.CloseInventory();
            }
            else
            {
                menuManager.OpenInventory();
            }
        }
    }
}
