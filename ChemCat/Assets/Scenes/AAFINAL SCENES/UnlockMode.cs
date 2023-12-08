using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockMode : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Standard, Quiz;
    // Start is called before the first frame update
    void Start()
    {
        Standard.interactable = false;
        Quiz.interactable = false;
        Unlock();
    }

    public void Unlock()
    {
        Debug.Log(PlayerPrefs.GetString("Story"));
        Debug.Log(PlayerPrefs.GetInt("LevelPassedmH"));
        if (PlayerPrefs.GetString("Story").Equals("Completed"))
        {
            Standard.interactable = true;
        }
        if (PlayerPrefs.GetInt("LevelPassedH") >= 5)
        {
            Quiz.interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Unlock();
    }
}
