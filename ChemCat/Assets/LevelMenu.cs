using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    // loads scene
    // reloads scene
    public void OpenLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void NextLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
