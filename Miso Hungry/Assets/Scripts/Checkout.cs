using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkout : MonoBehaviour
{
    private int loadNextLevel;
    private int index;

    bool CheckPlayerTag(string STRING)
    {
        if(STRING.Equals("Player"))
        {
            return true;
        }
        return false;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (CheckPlayerTag(other.gameObject.tag))
        {
            //get next scene, level 1
            loadNextLevel = SceneManager.GetActiveScene().buildIndex + 1;
            //load the next scene, level1
            SceneManager.LoadScene(loadNextLevel);
        }
    }
}
