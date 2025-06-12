// Scripts/CustomizationManager.cs
using UnityEngine;

public class CustomizationManager : MonoBehaviour {
    public void EquipItem(ItemType type, string itemID) {
        GameManager.Instance.player.equippedItems[type] = itemID;
    }
}
