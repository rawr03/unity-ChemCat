using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject settings;

    public void Resume()
    {
        settings.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        settings.SetActive(true);
        Time.timeScale = 0f;  
        GameIsPaused = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
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
