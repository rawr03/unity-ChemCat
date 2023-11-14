using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject stars, star1, star2, star3;

    public bool completed;
    public int recordScore;

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
        stars.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(completed == true)
        {
            stars.SetActive(true);
        }

        switch (recordScore)
        {
            case 0:
                star1.gameObject.SetActive(false);
                star2.gameObject.SetActive(false);
                star3.gameObject.SetActive(false);
                break;
            case 1:
                star1.gameObject.SetActive(true);
                star2.gameObject.SetActive(false);
                star3.gameObject.SetActive(false);
                break;
            case 2:
                star1.gameObject.SetActive(true);
                star2.gameObject.SetActive(true);
                star3.gameObject.SetActive(false);
                break;
            case 3:
                star1.gameObject.SetActive(true);
                star2.gameObject.SetActive(true);
                star3.gameObject.SetActive(true);
                break;

        }
    }
}
