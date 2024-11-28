using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartMenu : MonoBehaviour
{
    public string levelToLoad = "Game";

    public ScreenFader sceneFader;

    public void Play()
    {
        sceneFader.FadeTo(levelToLoad);
    }

    public void Quit()
    {
        Debug.Log("Exciting...");
        Application.Quit();
    }

}
