using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuuUI; 
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
	 }
}

    public void Resume()
    {
        pauseMenuuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }


        void Pause ()
        {
            pauseMenuuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }

    public void LoadMenu()
    {
        SceneManager.LoadScene("001_MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    }


