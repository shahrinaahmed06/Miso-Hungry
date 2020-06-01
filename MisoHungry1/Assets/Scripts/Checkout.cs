using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkout : MonoBehaviour
{
    private int loadNextLevel;
    private int index;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //get next scene, level 1
            loadNextLevel = SceneManager.GetActiveScene().buildIndex + 1;
            //load the next scene, level1
            SceneManager.LoadScene(loadNextLevel);
        }
    }
}
