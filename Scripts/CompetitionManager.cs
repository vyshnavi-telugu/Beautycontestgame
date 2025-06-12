// Scripts/CompetitionManager.cs
using UnityEngine;

public class CompetitionManager : MonoBehaviour {
    public void StartCompetition() {
        int playerScore = Random.Range(60, 100);  // Based on style match etc.
        int opponentScore = Random.Range(50, 100);

        if (playerScore > opponentScore) {
            Debug.Log("You win!");
            GameManager.Instance.AddCoins(50); // Reward
        } else {
            Debug.Log("You lost! Try again.");
        }

        GameManager.Instance.gameState = GameState.RESULTS;
    }
}
