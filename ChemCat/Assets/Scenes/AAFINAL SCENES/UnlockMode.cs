using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Analytics;
using Unity.Services.Analytics;

public class UnlockMode : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Standard, Quiz;
    // Start is called before the first frame update

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }


    void Start()
    {
        //Analytics.CustomEvent
        Standard.interactable = false;
        Quiz.interactable = false;
        Unlock();
    }

    public void Unlock()
    {
        //Debug.Log(PlayerPrefs.GetString("Story"));
        //Debug.Log(PlayerPrefs.GetInt("LevelPassedH"));
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
