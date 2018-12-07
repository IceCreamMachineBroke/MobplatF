using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public int lives = 5;
    
    void Start ()
    {
        PlayerPrefs.SetInt("Lives", lives);
    }
	
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
