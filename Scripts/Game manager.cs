// Scripts/GameManager.cs
using UnityEngine;

public class GameManager : MonoBehaviour {
    public static GameManager Instance;
    public GameState gameState = GameState.MAIN_MENU;
    public PlayerProfile player = new PlayerProfile();

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void AddCoins(int amount) {
        player.coins += amount;
    }

    public bool SpendCoins(int amount) {
        if (player.coins >= amount) {
            player.coins -= amount;
            return true;
        }
        return false;
    }
}
