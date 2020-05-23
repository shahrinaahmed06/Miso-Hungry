using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisoScript : MonoBehaviour
{
    public int score = 0;
    //when player and miso soup collision occurs
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Triggered!");
        Destroy(gameObject); //miso soup disappears 
        score +=10;
        Debug.Log("Score: " + score);
    }
}
