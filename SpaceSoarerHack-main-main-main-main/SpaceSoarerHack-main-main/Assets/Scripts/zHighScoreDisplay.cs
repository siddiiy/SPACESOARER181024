using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class zHighScoreDisplay : MonoBehaviour
{
    public TMP_Text highScoreText; // Reference to the UI Text for high score display

    void Start()
    {
        // Load the high score and player's name from PlayerPrefs
        float highScore = PlayerPrefs.GetFloat("HighScore", 0f);
        string highScorePlayer = PlayerPrefs.GetString("HighScorePlayer", "No one");

        // Update the high score text with the saved data
        highScoreText.text = "High Score: " + highScore.ToString("F2") + " by " + highScorePlayer;
    }
}
