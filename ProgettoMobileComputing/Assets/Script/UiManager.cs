using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public GameObject joystickUI;
    public GameObject gameOverUI;
    public GameObject pauseMenu;
    public PlayerHealth playerHealth;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
        pauseMenu.SetActive(false);
        playerHealth = FindAnyObjectByType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth.isDead){
            gameOverUI.SetActive(true);
            joystickUI.SetActive(false);
        }
    }

    public void MainMenuButton(){
        Time.timeScale = 1;
        FindAnyObjectByType<AudioManager>().Play("UISound");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
    public void RetryButton(){
        Time.timeScale = 1;
        FindAnyObjectByType<AudioManager>().Play("UISound");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void PauseButton(){
        FindAnyObjectByType<AudioManager>().Play("UISound");
        pauseMenu.SetActive(true);
        joystickUI.SetActive(false);
        Time.timeScale = 0;
    }
    public void ResumeButton(){
        FindAnyObjectByType<AudioManager>().Play("UISound");
        pauseMenu.SetActive(false);
        joystickUI.SetActive(true);
        Time.timeScale = 1;
    }
}
