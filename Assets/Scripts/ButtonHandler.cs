using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Handle all what button can do
/// </summary>
public class ButtonHandler : MonoBehaviour
{
    //Go to designated scene
    public void GoToSceneIndex(int index)
    {
        SceneManager.LoadScene(index);
    }

    //Restart loaded Scene
    public void RestartCurrentScene()
    {
        SceneManager.LoadScene(Application.loadedLevel);
    }

    //Go to next scene or back to main menu 
    public void GoToNextScene()
    {
        if (Application.loadedLevel <= 2)
        {
            SceneManager.LoadScene(Application.loadedLevel + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }

    //Close Application
    public void ExitGame()
    {
        Application.Quit();
    }
}
