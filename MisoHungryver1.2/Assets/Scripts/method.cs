using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class method : MonoBehaviour
{
    public void setcharacter (int id)
    {
        character.character1 = (Character)id;
        print(character.character1);
    }

    public void scenegenerator (string levelname)
    {
        SceneManager.LoadScene(levelname);
    }






}
