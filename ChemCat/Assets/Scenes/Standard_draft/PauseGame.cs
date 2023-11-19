using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject settings, reminder, instructions;

    public void Resume()
    {
        settings.gameObject.SetActive(false);
        reminder.gameObject.SetActive(false);
        instructions.gameObject.SetActive(false);
        //AudioManager.Instance.musicSource.UnPause();
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        settings.gameObject.SetActive(true);
        reminder.gameObject.SetActive(false);
        instructions.gameObject.SetActive(false);
        //AudioManager.Instance.musicSource.Pause();
        Time.timeScale = 0f;  
        GameIsPaused = true;
    }

    public void Exit()
    {
        settings.gameObject.SetActive(false);
        reminder.gameObject.SetActive(true);
        instructions.gameObject.SetActive(false);
        //AudioManager.Instance.musicSource.Pause();
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Help()
    {
        settings.gameObject.SetActive(false);
        reminder.gameObject.SetActive(false);
        instructions.gameObject.SetActive(true);
        //AudioManager.Instance.musicSource.UnPause();
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        reminder.gameObject.SetActive(false);
        settings.gameObject.SetActive(false);
        instructions.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
        */
    }
}
