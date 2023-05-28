using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject options;
    public static bool Gameispaused = false;
    public GameObject PausemenuUI;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Gameispaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        PausemenuUI.SetActive(false);
        Time.timeScale = 1f;
        Gameispaused = false;
        options.SetActive(false);
    }
    public void Pause()
    {
        PausemenuUI.SetActive(true);
        Time.timeScale = 0f;
        Gameispaused = true;
    }
    public void QuitMenu()
    {
        Application.Quit();
    }
    public void SettingsMenu()
    {
        PausemenuUI.SetActive(false);
        Time.timeScale = 0f;
        Gameispaused = true;
        options.SetActive(true);
    }

}
