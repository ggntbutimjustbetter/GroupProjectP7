using UnityEngine;
using UnityEngine.SceneManagement;  // For loading scenes
using UnityEngine.UI;              // For accessing UI buttons

public class GameOverController : MonoBehaviour
{
    // Reference to the Game Over UI Canvas
    public GameObject gameOverUI;
    public Button restartButton;
    public Button mainMenuButton;

    void Start()
    {
        // Ensure the Game Over UI is inactive at the start
        gameOverUI.SetActive(false);

        // Add listeners to buttons
        restartButton.onClick.AddListener(RestartGame);
        mainMenuButton.onClick.AddListener(GoToMainMenu);
    }

    // Call this method when the game is over
    public void TriggerGameOver()
    {
        gameOverUI.SetActive(true); // Show the Game Over UI
        Time.timeScale = 0f;         // Pause the game
    }

    // Restarts the current game
    void RestartGame()
    {
        Time.timeScale = 1f;                        // Resume game time
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  // Reload the current scene
    }

    // Goes back to the main menu scene
    void GoToMainMenu()
    {
        Time.timeScale = 1f;                        // Resume game time
        SceneManager.LoadScene("MainMenu");         // Load the Main Menu scene (make sure you have it in your build settings)
    }
}
