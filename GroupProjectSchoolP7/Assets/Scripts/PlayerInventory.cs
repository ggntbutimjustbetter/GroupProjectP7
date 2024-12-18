using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    public Text scoreText; // UI Text to show score
    private int score = 0;

    public List<InventoryItem> inventory = new List<InventoryItem>(); // List to hold collected items

    // Method to collect items and update score
    public void CollectItem(InventoryItem item)
    {
        // Add item to inventory
        inventory.Add(item);
        // Update score
        score += item.scoreValue;
        // Update the UI text
        UpdateScoreText();
        // Optionally destroy the item (or disable it)
        Destroy(item.gameObject);
    }

    // Update the score UI text
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}