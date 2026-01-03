using UnityEngine;

public class Inventory : MonoBehaviour
{
    // ENCAPSULATION
    public int coinCount
    {
        get { return m_coinCount; }
        set
        {
            if (value < 0)
            {
                Debug.LogError("Can't set negative coinCount for " + gameObject.name);
            }
            else
            {
                m_coinCount = value;
            }
        }
    }
    private int m_coinCount = 0;
    [SerializeField] private InventoryDisplay[] inventoryDisplays;

    private void Update()
    {
        foreach (InventoryDisplay display in inventoryDisplays)
        {
            display.SetCoins(coinCount);
        }
    }
}
