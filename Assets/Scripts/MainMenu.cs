using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;


public class MainMenu : MonoBehaviour
{
    public string Scene1="Scene1";
    public void StartGame()
    {
        SceneManager.LoadScene(Scene1);
    }

    
    public void QuitGame()
    {
        Application.Quit();
    }
}
