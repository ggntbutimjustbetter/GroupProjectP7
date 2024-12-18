using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public ScoreManager scoreManager;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ScoreItem")) // Assume the item has the "ScoreItem" tag
        {
            scoreManager.AddScore(1);  // Add 1 point to the score
            Destroy(other.gameObject);  // Destroy the collected item
        }
    }
}
