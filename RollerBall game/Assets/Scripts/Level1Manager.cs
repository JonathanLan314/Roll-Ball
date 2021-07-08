using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Manager : MonoBehaviour
{
    public Rigidbody playerRb;
    public GameObject pauseButton;
    public GameObject playButton;
    public PlayerMovement playerMovement;
    public GameObject mainMenu;

    void Start()
    {
        playerRb.constraints = RigidbodyConstraints.None;
        pauseButton.SetActive(true);
        playButton.SetActive(false);
        mainMenu.SetActive(false);
        playerMovement.enabled = true;
    }

    public void Pause()
    {
        playerRb.constraints = RigidbodyConstraints.FreezePosition;
        playerMovement.enabled = false;
        pauseButton.SetActive(false);
        mainMenu.SetActive(true);
        playButton.SetActive(true);
    }

    public void Play()
    {
        playerRb.constraints = RigidbodyConstraints.None;
        pauseButton.SetActive(true);
        playButton.SetActive(false);
        mainMenu.SetActive(false);
        playerMovement.enabled = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
