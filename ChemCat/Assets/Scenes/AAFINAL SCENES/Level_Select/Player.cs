using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    // CheckPoint in StoryMode
    public string CheckPoint;

    // Easy Scores
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

    // Medium Scores
    public int scoreM1;
    public int scoreM2;
    public int scoreM3;
    public int scoreM4;
    public int scoreM5;
    public int scoreM6;
    public int scoreM7;
    public int scoreM8;
    public int scoreM9;
    public int scoreM10;

    // Hard Scores
    public int scoreH1;
    public int scoreH2;
    public int scoreH3;
    public int scoreH4;
    public int scoreH5;
    public int scoreH6;
    public int scoreH7;
    public int scoreH8;
    public int scoreH9;
    public int scoreH10;

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

    // retrieve HighScore during exit from QuizMode
    public void GetHighScore()
    {
        //Highscore = Highscore;
    }

    public void PutInArray()
    {
        //Easy
        Easy[0] = scoreE1;
        Easy[1] = scoreE2;
        Easy[2] = scoreE3;
        Easy[3] = scoreE4;
        Easy[4] = scoreE5;
        Easy[5] = scoreE6;
        Easy[6] = scoreE7;
        Easy[7] = scoreE8;
        Easy[8] = scoreE9;
        Easy[9] = scoreE10;

        //Medium
        Medium[0] = scoreM1;
        Medium[1] = scoreM2;
        Medium[2] = scoreM3;
        Medium[3] = scoreM4;
        Medium[4] = scoreM5;
        Medium[5] = scoreM6;
        Medium[6] = scoreM7;
        Medium[7] = scoreM8;
        Medium[8] = scoreM9;
        Medium[9] = scoreM10;

        //Hard
        Hard[0] = scoreH1;
        Hard[1] = scoreH2;
        Hard[2] = scoreH3;
        Hard[3] = scoreH4;
        Hard[4] = scoreH5;
        Hard[5] = scoreH6;
        Hard[6] = scoreH7;
        Hard[7] = scoreH8;
        Hard[8] = scoreH10;
        Hard[9] = scoreH10;

    }

    public void GetEasyScores()
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

    public void GetMediumScores()
    {
        scoreM1 = PlayerPrefs.GetInt("ScoreM" + 1);
        scoreM2 = PlayerPrefs.GetInt("ScoreM" + 2);
        scoreM3 = PlayerPrefs.GetInt("ScoreM" + 3);
        scoreM4 = PlayerPrefs.GetInt("ScoreM" + 4);
        scoreM5 = PlayerPrefs.GetInt("ScoreM" + 5);
        scoreM6 = PlayerPrefs.GetInt("ScoreM" + 6);
        scoreM7 = PlayerPrefs.GetInt("ScoreM" + 7);
        scoreM8 = PlayerPrefs.GetInt("ScoreM" + 8);
        scoreM9 = PlayerPrefs.GetInt("ScoreM" + 9);
        scoreM10 = PlayerPrefs.GetInt("ScoreM" + 10);
    }

    public void GetHardScores()
    {
        scoreH1 = PlayerPrefs.GetInt("ScoreH" + 1);
        scoreH2 = PlayerPrefs.GetInt("ScoreH" + 2);
        scoreH3 = PlayerPrefs.GetInt("ScoreH" + 3);
        scoreH4 = PlayerPrefs.GetInt("ScoreH" + 4);
        scoreH5 = PlayerPrefs.GetInt("ScoreH" + 5);
        scoreH6 = PlayerPrefs.GetInt("ScoreH" + 6);
        scoreH7 = PlayerPrefs.GetInt("ScoreH" + 7);
        scoreH8 = PlayerPrefs.GetInt("ScoreH" + 8);
        scoreH9 = PlayerPrefs.GetInt("ScoreH" + 9);
        scoreH10 = PlayerPrefs.GetInt("ScoreH" + 10);
    }

    // retrieve level name of last CheckPoint
    public void GetCheckPoint()
    {
        
    }

}

