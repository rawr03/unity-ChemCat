using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public string lvlDiff;
    public int stars;
    public Button lv1, lv2, lv3, lv4, lv5, lv6, lv7, lv8, lv9, lv10;
    int levelPassed;
    S_draft sD;
    public int[] ScoreSummary;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;

    private void Start()
    {
        lvlDiff = lvlDiff.ToLower();
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        lv4.interactable = false;
        lv5.interactable = false;
        lv6.interactable = false;
        lv7.interactable = false;
        lv8.interactable = false;
        lv9.interactable = false;
        lv10.interactable = false;

        switch (levelPassed)
        {
            case 1:
                lv4.interactable = true;
                break;
            case 2:
                lv5.interactable = true;
                break;
            case 3:
                lv6.interactable = true;
                break;
            case 4:
                lv7.interactable = true;
                break;
            case 5:
                lv8.interactable = true;
                break;
            case 6:
                lv9.interactable = true;
                break;
            case 7:
                lv10.interactable = true;
                break;
        }

    }

    void RecordScores()
    {
        for (int i = 1; i <= 10; i++)
        {
            ScoreSummary[i] = PlayerPrefs.GetInt("Score" + lvlDiff + i);
        }
    }

    private void Update()
    {
        RecordScores();
    }

    void ShowStars()
    {
        //PlayerPrefs.GetInt("Score" + lvlDiff + i);
    }
}
