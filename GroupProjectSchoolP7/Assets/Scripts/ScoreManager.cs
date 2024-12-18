using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // For loading scenes


public class ScoreManager : MonoBehaviour
{
    public float scoreCount;
    public Text scoreText;
    public int score = 0;  // Keep track of the scor// UI Text to display the score (optional, if you want to display score)
    public GameOverController gameOverController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  // Reference to the GameOverController script to show game over UI

    void Update()
    {
        // If the score is 5 or more, trigger the game over
        if (score >= 5)
        {
            GameOver();
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);

        // Update the score text (optional)
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    // This method is called to increment the score
    public void AddScore(int points)
    {
        score += points;
    }

    // Call this method when the game is over (score reached 5)
    void GameOver()
    {
        gameOverController.TriggerGameOver();  // Trigger the Game Over
    }
}

