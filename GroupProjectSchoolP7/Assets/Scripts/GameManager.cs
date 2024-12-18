using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject endpanel;
    public static int score;
    public Text scoreText;
    public GameObject victoryTextObject;


    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateUI();
        victoryTextObject.SetActive(false);
    }

    public void UpdateScore(int amount)
    {
        score += amount;
        UpdateUI();

        if (score >= 5)
        {
            WinGame();
        }
    }

    public void UpdateUI()
    {
        scoreText.text = score.ToString();
    }

    public void WinGame()
    {
        victoryTextObject.SetActive(true);
    }

}
