using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject stars, star1, star2, star3;

    public string difficulty;
    public string lvlNum;
    public int Number;

    public int recordScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        difficulty = FindObjectOfType<LevelController>().difficulty;
        Number = int.Parse(lvlNum);
        stars.SetActive(true);
    }

    public void ButtonIsClicked()
    {
        Debug.Log("Clicked");
    }

    // Update is called once per frame
    void Update()
    {
        if (difficulty == "Easy")
        {
            recordScore = PlayerPrefs.GetInt("ScoreE" + Number);
        }
        if (difficulty == "Medium")
        {
            recordScore = PlayerPrefs.GetInt("ScoreM" + Number);
        }
        if (difficulty == "Hard")
        {
            recordScore = PlayerPrefs.GetInt("ScoreH" + Number);
        }
        if (difficulty == "Extreme")
        {
            recordScore = PlayerPrefs.GetInt("ScoreEx" + Number);
        }

        switch (recordScore)
        {
            case 0:
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
                break;
            case 1:
                star1.SetActive(true);
                star2.SetActive(false);
                star3.SetActive(false);
                break;
            case 2:
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(false);
                break;
            case 3:
                star1.SetActive(true);
                star2.SetActive(true);
                star3.SetActive(true);
                break;

        }
    }
}
