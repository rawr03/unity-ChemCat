using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    StoryControl stryC; // PlayerPrefs.SetInt("Checkpoint", SceneManager.GetActiveScene().buildIndex());
    QuizControl quiz;
    // PlayerPrefs.SetInt("HighScore", 0);
    // if(gameScore > PlayerPrefs.GetInt("HighScore", 0){ PlayerPrefs.SetInt("HighScore", gameScore); }
    // 
    LevelController lvC;

    public string CheckPoint = "E2";
    public int[] Easy = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 0 };
    public int[] Medium = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 0 };
    public int[] Hard = { 1, 2, 3, 1, 2, 3, 1, 2, 3, 0 };
    public int Highscore = 10;

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
        Highscore = quiz.gameScore;
    }

    // retrieve health during exit from Standard Levels
    public void GetEasyScores()
    {
        for(int i = 0; i < Easy.Length; i++)
        {
            /*
            if (sC.Heart1.active)
            {
                Easy[i] = 1;
            }
            else*/
        }
    }

    // retrieve level name of last CheckPoint
    public void GetCheckPoint()
    {
        
    }

}

