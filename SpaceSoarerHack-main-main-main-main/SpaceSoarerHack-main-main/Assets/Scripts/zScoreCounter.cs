using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zScoreCounter : MonoBehaviour

{
    public TMP_Text scoreText; // Reference to the Text component
    public float score = 0f; // Track the score
    public float scoreSpeed = 1f; // Speed at which the score increases

    private string playerName; // Store the player's name

    void Start()
    {
        // Load the player's name from PlayerPrefs
        playerName = PlayerPrefs.GetString("PlayerName", "Unknown");
    }

    void Update()
    {
        // Increase the score over time
        score += Time.deltaTime * scoreSpeed;

        // Update the score text
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
    }

    // This method will be called when the player presses the End Game button
    public void EndGame()
    {
        // Save the score and player's name to PlayerPrefs
        PlayerPrefs.SetFloat("HighScore", score);
        PlayerPrefs.SetString("HighScorePlayer", playerName);
        PlayerPrefs.Save();

        // End the game (this can be a scene transition or any other logic)
        SceneManager.LoadScene("Main"); // Replace "MainMenu" with your actual scene name for the main menu or end game
    }
}