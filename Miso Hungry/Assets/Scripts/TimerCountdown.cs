using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
 * Author: Shahrina  Ahmed
 * 17999929
 * 
 * This is a script for activate time and end level menu.
 * When timer reaches at 0 it will activate the end level menu with restart and quit button.
 * Restart button start the level and quit button exit the game.
 */

public class TimerCountdown : MonoBehaviour
{

    public GameObject textDisplay;//gameobject for displaying time
    public GameObject EndMenu;//gameobject end level menu
    public int secondsLeft = 20;//seconds for level
    public bool takingAway = false;
    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;

    }

    // Update is called once per frame
    void Update()
    {
        if (takingAway == false && secondsLeft > 0 )
        {
            StartCoroutine(TimerTake()); 
        }
        
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        if ((secondsLeft < 10)&&(Score.score>0))
        {
            textDisplay.GetComponent<Text>().text = "00:0" + secondsLeft;

        }
        if ((secondsLeft <= 0)||(Score.score<0))//when timer reaches to 0 sec
        {
            EndMenu.SetActive(true);//activate the end level menu
            Time.timeScale = 0;// stops scene 
        }

        else
        {
            textDisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        }
        takingAway = false;
    }

    public void ReStart()//function to resatrt the level
    {
        EndMenu.SetActive(false);//deactivate the end level menu
        Time.timeScale = 1;/// start scene 

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//return the level played level.

    }

    public void MainMenu()//manin menu loaded here
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main_Menu");
    }
    public void QuitGame()//function for quit game
    {
        Debug.Log("Quit game...");
        Application.Quit();//quit the whole application

    }
}
