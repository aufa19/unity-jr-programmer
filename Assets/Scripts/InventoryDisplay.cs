using UnityEngine;
using UnityEngine.UI;

public class InventoryDisplay : MonoBehaviour
{
    [SerializeField] private Text text;

    public void SetCoins(int coins)
    {
        text.text = "Coins: " + coins;
    }
}
