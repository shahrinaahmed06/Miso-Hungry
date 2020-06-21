using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int score;
    private Text scoreText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 0;
    }

   {
        if (score >= 0)
        {
        scoreText.text = "score: " + score;

        }
        else if(score < 0)
        {
            score = -1;
            scoreText.text = "score: 0";
        }
    }
}
