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

    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
