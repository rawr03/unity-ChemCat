using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject settings, reminder;

    public void Resume()
    {
        settings.gameObject.SetActive(false);
        reminder.gameObject.SetActive(false);
        //AudioManager.Instance.musicSource.UnPause();
        Time.timeScale = 1;
        GameIsPaused = false;
        Debug.Log("PauseGame:Play");
    }

    public void Pause()
    {
        settings.gameObject.SetActive(true);
        reminder.gameObject.SetActive(false);
        //AudioManager.Instance.musicSource.Pause();
        Time.timeScale = 0;  
        GameIsPaused = true;
        Debug.Log("PauseGame:Paused");
    }

    public void Exit()
    {
        settings.gameObject.SetActive(false);
        reminder.gameObject.SetActive(true);
        //AudioManager.Instance.musicSource.Pause();
        Time.timeScale = 0;
        GameIsPaused = true;
        Debug.Log("PauseGame:Paused");
    }

    // Start is called before the first frame update
    void Start()
    {
        reminder.gameObject.SetActive(false);
        settings.gameObject.SetActive(false);
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
