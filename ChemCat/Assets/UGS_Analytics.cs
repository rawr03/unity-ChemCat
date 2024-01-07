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
    }*/

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

        /*
        Dictionary<string, object> parameters = new Dictionary<string, object>()
        {
            { "storyMode", true},
            { "standardMode", false},
            { "quizMode", false }
        };
        AnalyticsService.Instance.CustomData("gameProgress", parameters);*/
    }

    public void GiveConsent()
    {
        // Call if consent has been given by the user
        AnalyticsService.Instance.StartDataCollection();
        Debug.Log($"Consent has been provided. The SDK is now collecting data!");
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

}
