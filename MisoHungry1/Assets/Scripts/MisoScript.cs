using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisoScript : MonoBehaviour
{
    public int score = 0;
    //when player and miso soup collision occurs
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if collides with player sprite, not obstacles
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject); //miso soup disappears 
            score += 10;
            Debug.Log("Score: " + score);
        }
    }
}
