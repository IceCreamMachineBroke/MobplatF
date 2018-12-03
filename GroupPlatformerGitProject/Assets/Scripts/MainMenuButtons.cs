using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour {
    public int lives = 10;
    public void Start()
    {
        PlayerPrefs.SetInt("Lives", lives);
    }
    public void NewGame()
    {
        
        SceneManager.LoadScene("Game1");


    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
