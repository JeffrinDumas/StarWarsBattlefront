using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
 public void StartGame(string StartGame)
    {
        SceneManager.LoadScene(StartGame);
    }

    public void QuitGame(string QuitGame)
    {
        Application.Quit();
    }
}