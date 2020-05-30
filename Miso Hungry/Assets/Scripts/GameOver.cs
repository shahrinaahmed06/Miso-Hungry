using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject Gameover;
    // Start is called before the first frame update
    public void ReStart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }

    // Update is called once per frame
    public void Quit()
    {
        Debug.Log("Quit Game...");
        Application.Quit(); 
    }
}
