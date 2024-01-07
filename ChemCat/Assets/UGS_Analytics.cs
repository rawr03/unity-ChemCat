using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Analytics;
using Unity.Services.Core;
using Unity.Services.Core.Analytics;
using UnityEngine.UI;
using UnityEngine.Analytics;
using System;

public class UGS_Analytics : MonoBehaviour
{
    // if a button is active, make bool true
    //private int playerScore = 0;
    //private int playerLevel = 1;
    public GameObject stry;
    public GameObject stnd;
    public GameObject quiz;
    bool btnPressed = false; 

    void Update()
    {
        /*
        if (stry.activeSelf == true && btnPressed == true)
        {
            TrackCustomEvent("gameProgress", "storyMode", true);
        }

        if (stnd.activeSelf == true && btnPressed == true)
        {
            TrackCustomEvent("gameProgress", "standardMode", true);
        }

        if (quiz.activeSelf == true && btnPressed == true)
        {
            TrackCustomEvent("gameProgress", "quizMode", true);
        }

        
        // Example: Track event when player reaches a certain score
        if (playerScore >= 1000)
        {
            TrackCustomEvent("HighScoreReached");
        }

        // Example: Track event when player reaches a certain level
        if (playerLevel == 5)
        {
            TrackCustomEvent("LevelReached", "Level", playerLevel);
        }*/
    }

    public void PressedStry()
    {
        btnPressed = true;
        TrackCustomEvent("gameProgress", "storyMode", true);
        Debug.Log(stry.activeSelf == true);
        Debug.Log(btnPressed);
        btnPressed = false;
    }

    public void PressedStnd()
    {
        btnPressed = true;
        if (stnd.activeSelf == true && btnPressed == true)
        {
            TrackCustomEvent("gameProgress", "standardMode", true);
            Debug.Log(stnd.activeSelf == true);
            Debug.Log(btnPressed);
        }
        btnPressed = false;
    }

    public void PressedQuiz()
    {
        btnPressed = true;
        if (quiz.activeSelf == true && btnPressed == true)
        {
            TrackCustomEvent("gameProgress", "quizMode", true);
            Debug.Log(quiz.activeSelf == true);
            Debug.Log(btnPressed);
        }
        btnPressed = false;
    }

    void TrackCustomEvent(string eventName, params object[] parameters)
    {
        // Create a dictionary to store parameters for the custom event
        var eventParams = new Dictionary<string, object>
        {
            { "storyMode", true},
            { "standardMode", false},
            { "quizMode", false }
        };

        /*
        // Add parameters to the dictionary
        for (int i = 0; i < parameters.Length; i += 2)
        {
            if (i + 1 < parameters.Length)
            {
                string key = parameters[i].ToString();

                // Check if the key already exists in the dictionary
                if (!eventParams.ContainsKey(key))
                {
                    eventParams.Add(key, parameters[i + 1]);
                }
                else
                {
                    // Handle the case where the key already exists (optional)
                    Debug.LogWarning($"Key '{key}' already exists in the dictionary.");
                }
            }
        }*/

        // Record the custom event
        Analytics.CustomEvent(eventName, eventParams);
    }


    /* TRY 3
    void Start()
    {
        var result = Analytics.CustomEvent("Location", transform.position);
        var state = new Dictionary<string, object>();
        state["storyMode"] = 57;
        state["standardMode"] = false;
        state["quizMode"] = false;

        result = Analytics.CustomEvent("gameProgress", state);
        Debug.Log("Button was pressed: " + result);

    }

    public void buttonPressed()
    {

    }*/

    /* TRY 2
    bool btn_story = false;
    public void ModeBtn()
    {
        Dictionary<string, object> parameters = new Dictionary<string, object>()
        {
                { "storyMode", true},
                { "standardMode", false},
                { "quizMode", false }
        };

        if(btn_story == true)
        {
            AnalyticsService.Instance.CustomData("gameProgress", parameters);
        }

        //Analytics.CustomEvent
        //Events.CustomData("gameProgress", parameters);
    }*

    /*
    public GameObject story;
    string storybtn = "btn.storymode";
    async void Start()
    {
        try
        {
            await UnityServices.InitializeAsync();
            GiveConsent(); // Get user consent according to various legislations
            //LevelCompletedCustomEvent();
        }
        catch (ConsentCheckException e)
        {
            Debug.Log(e.ToString());
        }
    }

    /*
    private void LevelCompletedCustomEvent()
    {
        int currentLevel = Random.Range(1, 4); // Gets a random number from 1-3

        // Define Custom Parameters
        Dictionary<string, object> parameters = new Dictionary<string, object>()
        {
            { "levelName", "level" + currentLevel.ToString()}
        };

        // The ‘levelCompleted’ event will get cached locally
        //and sent during the next scheduled upload, within 1 minute
        AnalyticsService.Instance.CustomData("levelCompleted", parameters);

        // You can call Events.Flush() to send the event immediately
        AnalyticsService.Instance.Flush();
    }

    private void UnlockMain()
    {
        var mainBtn = new Dictionary<string, object>();
        mainBtn["storyMode"] = true;
        mainBtn["standardMode"] = false;
        mainBtn["quizMode"] = false;

        story = GameObject.Find(storybtn);
        if(story.activeSelf == true)
        {
            mainBtn["storyMode"] = true;
            Debug.Log("Story Mode is active");
        }
        AnalyticsResult result = Analytics.CustomEvent("gameProgress", mainBtn);
        Debug.Log(result.ToString());

      
        Dictionary<string, object> parameters = new Dictionary<string, object>()
        {
            { "storyMode", true},
            { "standardMode", false},
            { "quizMode", false }
        };
        AnalyticsService.Instance.CustomData("gameProgress", parameters);
    }

    public void GiveConsent()
    {
        // Call if consent has been given by the user
        AnalyticsService.Instance.StartDataCollection();
        Debug.Log($"Consent has been provided. The SDK is now collecting data!");
        //RecordGameProgress();
    }

    public static class RecordGameProgress
    {
        public static void RecordCustomEventWithNoParameters()
        {
            AnalyticsService.Instance.CustomData("gameProgress", new Dictionary<string, object>());
        }

        public static void RecordCustomEventWithNoParameters(string EventName)
        {
            AnalyticsService.Instance.CustomData(EventName, new Dictionary<string, object>());
        }

        public static void RecordCustomEventWithParameters()
        {
            var parameters = new Dictionary<string, object>
            {
                { "storyMode", true},
                { "standardMode", false},
                { "quizMode", false }
            };

            AnalyticsService.Instance.CustomData("gameProgress", parameters);
        }

        //Debug.Log("Recorded gameProgress");
    }
    */
}
