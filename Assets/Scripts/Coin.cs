using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Inventory>(out Inventory inventory))
        {
            inventory.coinCount += 1;
            Destroy(gameObject);
        }
    }
}
