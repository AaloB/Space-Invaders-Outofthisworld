using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CountDownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    bool isGameOver = false;

    [SerializeField] TMP_Text countdownText;
    [SerializeField] TMP_Text gameOverText; // Add reference to Game Over text

    [SerializeField] GameObject startPanel; // Reference to the start panel
    [SerializeField] Button startButton; // Reference to the start button

    public void Start()
    {
        currentTime = startingTime;
        gameOverText.gameObject.SetActive(false); // Hide the Game Over text initially
        startPanel.SetActive(true); // Show the start panel
        startButton.onClick.AddListener(StartGame); // Add listener to the start button
    }
    public void Update()
    {
        if (!isGameOver)
        {
            if (startPanel.activeSelf) // Return if the start panel is still active
                return;

            currentTime -= 1 * Time.deltaTime;
             countdownText.text = currentTime.ToString("0");

            if(currentTime <= 0)
            {
            currentTime = 0;
                isGameOver = true;
                GameOver(); // Call the GameOver function when the timer is over
            }
        }
    }
    void GameOver()
    {
        // display game over text and stop the game
        gameOverText.gameObject.SetActive(true);
        gameOverText.text = "Game Over";
        Time.timeScale = 0; // This will stop the game
    }
    void StartGame()
    {
        startPanel.SetActive(false); // Hide the start panel when the game starts
    }

}
