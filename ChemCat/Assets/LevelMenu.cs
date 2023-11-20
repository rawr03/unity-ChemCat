using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMenu : MonoBehaviour
{
    /*private void Start()
    {
        GetComponent<Button>().onClick.AddListener(BClickSound);
    }

    private void BClickSound()
    {
        AudioManager.Instance.PlaySFX("Click");
    }*/

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
