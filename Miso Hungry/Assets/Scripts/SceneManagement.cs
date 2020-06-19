using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
  public void GotoLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

  public void GotoLevel2()
    {
        SceneManager.LoadScene("Level2");
    }
  public void GotoLevel3()
    {
        SceneManager.LoadScene("Level3");
    }
  public void GotoChangeAvatar()
    {
        SceneManager.LoadScene("ChangeAvatar");
    }
}
