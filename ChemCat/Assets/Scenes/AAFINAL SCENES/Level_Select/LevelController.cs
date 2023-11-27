using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public string difficulty;
    public Button lv1, lv2, lv3, lv4, lv5, lv6, lv7, lv8, lv9, lv10;
    int levelPassed;
    public int[] ScoreSummaryE;
    public int[] ScoreSummaryM;
    public int[] ScoreSummaryH;

    private void Start()
    {
        PlayerPrefs.DeleteAll();
        //difficulty = difficulty.ToUpper();
        lv4.interactable = false;
        lv5.interactable = false;
        lv6.interactable = false;
        lv7.interactable = false;
        lv8.interactable = false;
        lv9.interactable = false;
        lv10.interactable = false;
    }

    void RecordScores()
    {
        for (int i = 1; i <= 10; i++)
        {
            ScoreSummaryE[i] = PlayerPrefs.GetInt("ScoreE" + i);
            ScoreSummaryM[i] = PlayerPrefs.GetInt("ScoreM" + i);
            ScoreSummaryH[i] = PlayerPrefs.GetInt("ScoreH" + i);
        }
        Debug.Log(ScoreSummaryE.ToString());
    }

    private void Update()
    {
        if (difficulty == "Easy")
        {
            levelPassed = PlayerPrefs.GetInt("LevelPassedE");
        }
        else if (difficulty == "Medium")
        {
            levelPassed = PlayerPrefs.GetInt("LevelPassedM");
        }
        else if (difficulty == "Hard")
        {
            levelPassed = PlayerPrefs.GetInt("LevelPassedH");
        }
        Debug.Log(levelPassed);
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
        RecordScores();
    }

}
