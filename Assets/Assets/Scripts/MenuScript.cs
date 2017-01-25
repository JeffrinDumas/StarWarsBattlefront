using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
 public void StartGame(string StartGame)
    {
        StartCoroutine(DeathDelay());
        SceneManager.LoadScene(StartGame);
    }

    public void QuitGame(string QuitGame)
    {
        Application.Quit();
    }
    IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(3);
    }

}