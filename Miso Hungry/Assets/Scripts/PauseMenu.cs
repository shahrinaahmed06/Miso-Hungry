using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Autor: Shahrina Ahmed (wdq1809@aut.ac.nz)
 * This script load the pause button and pause menu 
 * while pausing and resuming the game. This also conatin the main menu function
 * and quiting game to go back to main menu or quit the game after pausing the game.
 */

public class PauseMenu : MonoBehaviour
{
    public GameObject Pausemenu, PauseButton;

    public void Pause()//Pause menu function to activate pause menu and pause the game
    {
        Pausemenu.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0;
    }


    public void Resume()//Resume function to get back to game from pause
    {
        Pausemenu.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1;
    }

    public void MainMenu()//manin menu need to be loaded here
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main_Menu");
    }

    public void QuitGame()//Quiting game need to be loaded here
    {
        Debug.Log("Quit game...");
        Application.Quit();

    }
}
