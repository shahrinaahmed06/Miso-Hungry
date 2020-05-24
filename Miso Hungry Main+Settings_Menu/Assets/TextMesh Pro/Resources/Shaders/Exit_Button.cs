using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_Button : MonoBehaviour
{
    // Exitgame is called when Exit_Button is pressed.
    public void Exitgame ()
    {
        Debug.Log("EXIT GAME");
        Application.Quit();
    }
}
