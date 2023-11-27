using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public string difficulty;
    public Button lv1, lv2, lv3, lv4, lv5, lv6, lv7, lv8, lv9, lv10;
    int levelPassed;
    public int scoreE1;
    public int scoreE2;
    public int scoreE3;
    public int scoreE4;
    public int scoreE5;
    public int scoreE6;
    public int scoreE7;
    public int scoreE8;
    public int scoreE9;
    public int scoreE10;
    public int[] Easy;

    List<int> Scores = new List<int>();
    
    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        //difficulty = difficulty.ToUpper();
        lv4.interactable = false;
        lv5.interactable = false;
        lv6.interactable = false;
        lv7.interactable = false;
        lv8.interactable = false;
        lv9.interactable = false;
        lv10.interactable = false;

        if(difficulty == "Easy")
        {
            ListEasy();
        }
        else if(difficulty == "Medium")
        {
            ListMedium();
        }
        else if (difficulty == "Hard")
        {
            ListHard();
        }
    }

    void ListEasy()
    {
        scoreE1 = PlayerPrefs.GetInt("ScoreE" + 1);
        scoreE2 = PlayerPrefs.GetInt("ScoreE" + 2);
        scoreE3 = PlayerPrefs.GetInt("ScoreE" + 3);
        scoreE4 = PlayerPrefs.GetInt("ScoreE" + 4);
        scoreE5 = PlayerPrefs.GetInt("ScoreE" + 5);
        scoreE6 = PlayerPrefs.GetInt("ScoreE" + 6);
        scoreE7 = PlayerPrefs.GetInt("ScoreE" + 7);
        scoreE8 = PlayerPrefs.GetInt("ScoreE" + 8);
        scoreE9 = PlayerPrefs.GetInt("ScoreE" + 9);
        scoreE10 = PlayerPrefs.GetInt("ScoreE" + 10);

    }

    void ListMedium()
    {
        scoreE1 = PlayerPrefs.GetInt("ScoreM" + 1);
        scoreE2 = PlayerPrefs.GetInt("ScoreM" + 2);
        scoreE3 = PlayerPrefs.GetInt("ScoreM" + 3);
        scoreE4 = PlayerPrefs.GetInt("ScoreM" + 4);
        scoreE5 = PlayerPrefs.GetInt("ScoreM" + 5);
        scoreE6 = PlayerPrefs.GetInt("ScoreM" + 6);
        scoreE7 = PlayerPrefs.GetInt("ScoreM" + 7);
        scoreE8 = PlayerPrefs.GetInt("ScoreM" + 8);
        scoreE9 = PlayerPrefs.GetInt("ScoreM" + 9);
        scoreE10 = PlayerPrefs.GetInt("ScoreM" + 10);

    }

    void ListHard()
    {
        scoreE1 = PlayerPrefs.GetInt("ScoreH" + 1);
        scoreE2 = PlayerPrefs.GetInt("ScoreH" + 2);
        scoreE3 = PlayerPrefs.GetInt("ScoreH" + 3);
        scoreE4 = PlayerPrefs.GetInt("ScoreH" + 4);
        scoreE5 = PlayerPrefs.GetInt("ScoreH" + 5);
        scoreE6 = PlayerPrefs.GetInt("ScoreH" + 6);
        scoreE7 = PlayerPrefs.GetInt("ScoreH" + 7);
        scoreE8 = PlayerPrefs.GetInt("ScoreH" + 8);
        scoreE9 = PlayerPrefs.GetInt("ScoreH" + 9);
        scoreE10 = PlayerPrefs.GetInt("ScoreH" + 10);
    }

    private void Update()
    {
        if (difficulty == "Easy")
        {
            levelPassed = PlayerPrefs.GetInt("LevelPassedE");
            //RecordEasy();
        }
        else if (difficulty == "Medium")
        {
            levelPassed = PlayerPrefs.GetInt("LevelPassedM");
            //RecordMedium();
        }
        else if (difficulty == "Hard")
        {
            levelPassed = PlayerPrefs.GetInt("LevelPassedH");
            //RecordHard();
        }

        switch (levelPassed)
        {
            case 3:
                lv4.interactable = true;
                break;
            case 4:
                lv4.interactable = true;
                lv5.interactable = true;
                break;
            case 5:
                lv4.interactable = true;
                lv5.interactable = true;
                lv6.interactable = true;
                break;
            case 6:
                lv4.interactable = true;
                lv5.interactable = true;
                lv6.interactable = true;
                lv7.interactable = true;
                break;
            case 7:
                lv4.interactable = true;
                lv5.interactable = true;
                lv6.interactable = true;
                lv7.interactable = true;
                lv8.interactable = true;
                break;
            case 8:
                lv4.interactable = true;
                lv5.interactable = true;
                lv6.interactable = true;
                lv7.interactable = true;
                lv8.interactable = true;
                lv9.interactable = true;
                break;
            case 9:
                lv4.interactable = true;
                lv5.interactable = true;
                lv6.interactable = true;
                lv7.interactable = true;
                lv8.interactable = true;
                lv9.interactable = true;
                lv10.interactable = true;
                break;
            case 10:
                lv4.interactable = true;
                lv5.interactable = true;
                lv6.interactable = true;
                lv7.interactable = true;
                lv8.interactable = true;
                lv9.interactable = true;
                lv10.interactable = true;
                break;
        }
    }


}
