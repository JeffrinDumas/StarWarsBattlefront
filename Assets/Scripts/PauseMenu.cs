using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject canvas;

    private MenuScript menu;
   
    void Start ()
    {
        menu = GetComponent<MenuScript>();

        canvas.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void MainMenu(string MainMenu)
    {
        SceneManager.LoadScene(MainMenu);
        Time.timeScale = 1;
    }

    public void Restart(string StartGame)
    {
        SceneManager.LoadScene(StartGame);
        Time.timeScale = 1;
    }

    public void Pause()
    {
       
            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;
            }

    }


}
