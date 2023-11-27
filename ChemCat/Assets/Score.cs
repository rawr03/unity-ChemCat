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

    /*
 namespace LevelUnlockSystem
 {
    public class LevelSystemManager : MonoBehavior
    {
        private static LevelSystemManager instance;

        [SerializeField]
        private LevelData levelData;

        public LevelData {get => levelData;}

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }


    [System.Serializable]
    public class LevelData
    {
        public int lasUnlockedLevel = 0;
        public LevelItem[] levelItemArray;
    }

    [System.Serializable]
    public class LevelItem
    {
        public bool unlocked;
        public int starAchieved;
    }
}

    */

    /*
namespace LevelUnlockSystem
{
    public class LevelUIManager : MonoBehavior
    {
        [SerializeField] private GameObject lvlBtnHolder
        [SerializeField] private GameObject lvlBtnPrefab;

        public void InitializeUI()
        {
            LevelItem[] levelItemArray = LevelSystemManager.Instance.LevelData.levelItemArray;
            for (int i = 0; i < levelItemArray.Length; i++)
            {

            }
        }
    }
}
    */
    
    
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
