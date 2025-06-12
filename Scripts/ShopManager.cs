// Scripts/ShopManager.cs
using UnityEngine;

public class ShopManager : MonoBehaviour {
    public void BuyItem(string itemID, int cost) {
        if (GameManager.Instance.SpendCoins(cost)) {
            GameManager.Instance.player.unlockedItems.Add(itemID);
            Debug.Log("Item bought: " + itemID);
        } else {
            Debug.Log("Not enough coins!");
        }
    }

    public bool IsItemUnlocked(string itemID) {
        return GameManager.Instance.player.unlockedItems.Contains(itemID);
    }
}
