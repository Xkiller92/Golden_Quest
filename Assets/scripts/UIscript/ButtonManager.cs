using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
 
    public void ApplicationStart()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void ApplictionQuit()
    {
        Application.Quit();
    }

    public void LevelRestart()
    {
        SceneManager.LoadScene("Level_1");
    }
}
