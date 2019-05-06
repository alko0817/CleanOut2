using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void tutorial ()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void quitGame()
    {
        Debug.Log("quit!");
        Application.Quit();     
    }
}
