// Scripts/PlayerProfile.cs
using System.Collections.Generic;

[System.Serializable]
public class PlayerProfile {
    public int coins = 0;
    public List<string> unlockedItems = new List<string>(); // item IDs
    public Dictionary<ItemType, string> equippedItems = new Dictionary<ItemType, string>();
}
