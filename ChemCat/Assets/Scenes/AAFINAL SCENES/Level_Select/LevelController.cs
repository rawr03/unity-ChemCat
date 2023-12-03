using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public string difficulty;
    public Button lv1, lv2, lv3, lv4, lv5, lv6, lv7, lv8, lv9, lv10, lv11, lv12, lv13, lv14, lv15;
    int levelPassed;

    public int[] Easy;
    public int[] Medium;
    public int[] Hard;

    
    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        Easy = new int[15];
        Medium = new int[15];
        Hard = new int[15];

        lv4.interactable = false;
        lv5.interactable = false;
        lv6.interactable = false;
        lv7.interactable = false;
        lv8.interactable = false;
        lv9.interactable = false;
        lv10.interactable = false;
        lv11.interactable = false;
        lv12.interactable = false;
        lv13.interactable = false;
        lv14.interactable = false;
        lv15.interactable = false;

        ListArray();
        
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
    }

    void ListArray()
    {
        for(int i = 1; i <= Easy.Length; i++)
        {
            Easy[i] = PlayerPrefs.GetInt("ScoreE" + i);
            Medium[i] = PlayerPrefs.GetInt("ScoreM" + i);
            Hard[i] = PlayerPrefs.GetInt("ScoreH" + i);
        }
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
                lv11.interactable = true;
                break;
            case 11:
                lv4.interactable = true;
                lv5.interactable = true;
                lv6.interactable = true;
                lv7.interactable = true;
                lv8.interactable = true;
                lv9.interactable = true;
                lv10.interactable = true;
                lv11.interactable = true;
                lv12.interactable = true;
                break;
            case 12:
                lv4.interactable = true;
                lv5.interactable = true;
                lv6.interactable = true;
                lv7.interactable = true;
                lv8.interactable = true;
                lv9.interactable = true;
                lv10.interactable = true;
                lv11.interactable = true;
                lv12.interactable = true;
                lv13.interactable = true;
                break;
            case 13:
                lv4.interactable = true;
                lv5.interactable = true;
                lv6.interactable = true;
                lv7.interactable = true;
                lv8.interactable = true;
                lv9.interactable = true;
                lv10.interactable = true;
                lv11.interactable = true;
                lv12.interactable = true;
                lv13.interactable = true;
                lv14.interactable = true;
                break;
            case 14:
                lv4.interactable = true;
                lv5.interactable = true;
                lv6.interactable = true;
                lv7.interactable = true;
                lv8.interactable = true;
                lv9.interactable = true;
                lv10.interactable = true;
                lv11.interactable = true;
                lv12.interactable = true;
                lv13.interactable = true;
                lv14.interactable = true;
                lv15.interactable = true;
                break;
            case 15:
                lv4.interactable = true;
                lv5.interactable = true;
                lv6.interactable = true;
                lv7.interactable = true;
                lv8.interactable = true;
                lv9.interactable = true;
                lv10.interactable = true;
                lv11.interactable = true;
                lv12.interactable = true;
                lv13.interactable = true;
                lv14.interactable = true;
                lv15.interactable = true;
                break;
        }
    }


}
