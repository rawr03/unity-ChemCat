using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    // CheckPoint in StoryMode
    public string CheckPoint;

    // Quiz Highscore
    public int Highscore;

    public int[] Easy;
    public int[] Medium;
    public int[] Hard;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        CheckPoint = data.CheckPoint;
        Easy = data.Easy;
        Medium = data.Medium;
        Hard = data.Hard;
        Highscore = data.Highscore;
    }

    // retrieve Scores from Standard Mode
    public void GetScores()
    {
        Easy = new int[10];
        Medium = new int[10];
        Hard = new int[10];

        for (int i = 1; i <= Easy.Length; i++)
        {
            Easy[i] = PlayerPrefs.GetInt("ScoreE" + i);
            Medium[i] = PlayerPrefs.GetInt("ScoreM" + i);
            Hard[i] = PlayerPrefs.GetInt("ScoreH" + i);
        }
    }


    // retrieve HighScore during exit from QuizMode
    public void GetHighScore()
    {
        Highscore = PlayerPrefs.GetInt("NewHighScore");
        //Highscore = Highscore;
    }

   
    // retrieve level name of last CheckPoint
    public void GetCheckPoint()
    {
        
    }

}

