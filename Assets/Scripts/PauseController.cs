using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour {

    public static bool gameIsPaused = false;
    private string menu = "MainMenuScene";

    // Currently setting this object in inspector
    // Could use a game object.Find() - will need something like that for multi scene
    // or would a DontDestroyOnLoad work? On this or the pause menu canvas or both?
    public GameObject pauseMenuUI; 

    void Update ()
    {
        // Im sure this will become a bug if I add some screen controls... 
        // Could just have a pause button then though
        // Pause on touch if not already paused
        if (Input.GetMouseButtonDown(0) && !gameIsPaused)
        {
            Pause();
        }
	}

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
        AudioListener.pause = true;
    }


    // Accessed by the canvas event system
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
        AudioListener.pause = false;
    }

    // Accessed by the canvas event system
    public void Quit()
    { 
        Application.Quit();
    }

    //This isn't being used currently
    void LoadMenu()
    {
        //Game time will be paused and should be resumed here
        Time.timeScale = 1f;
        AudioListener.pause = false;
        // or call some other script perhaps from SceneController...???
        SceneManager.LoadScene(menu);
    }
}
