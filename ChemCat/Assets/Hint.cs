using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] Sp_eggs;
    public GameObject heart1, heart2, heart3, caterpillar, Db_hint;
    public TextMeshProUGUI hintText;
    int[] switchNum;
    int[] answers;
    int randIndex;
    int randSwitch;
    int answer;
    public int currentLevel;

    //S_draft s_Draft;
    void Start()
    {
        Sp_eggs = Resources.LoadAll<Sprite>("sp_caterpillar");
        //Debug.Log(randIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (heart1.activeSelf == true && heart2.activeSelf == false && heart3.activeSelf == false)
        {
            ChangeSprite(5);
        }
        else if (heart1.activeSelf == true && heart2.activeSelf == true && heart3.activeSelf == false)
        {
            ChangeSprite(8);
        }
        else
        {
            ChangeSprite(1);
        }
        hintText.text = "Switch " + PlayerPrefs.GetInt("CurrentSwitch" + currentLevel.ToString(), 0) + " has the COEFFICIENT " + PlayerPrefs.GetInt("CurrentAnswer" + currentLevel.ToString(), 0);
        //hintText.SetText("Switch {0} + has the COEFFICIENT + {1}.", randSwitch, answer);
    }

    public void showHint()
    {
        Db_hint.SetActive(true);
    }

    public void AssignValues(int answer1, int answer2, int answer3,int answer4, int currentEq)
    {
        randIndex = Random.Range(0, 4);
        switchNum = new int[4];
        answers = new int[4];
        switchNum[0] = 1;
        switchNum[1] = 2;
        switchNum[2] = 3;
        switchNum[3] = 4;
        //Debug.Log(switchNum.ToString());

        answers[0] = answer1;
        answers[1] = answer2;
        answers[2] = answer3;
        answers[3] = answer4;

        randSwitch = switchNum[randIndex];
        answer = answers[randIndex];
        //currentLevel = currentEq + 1;

        Debug.Log("Retrieved Equation #: " + currentEq);
        //currentLevel = currentLevel + 1;
        
        //Debug.Log("Retrieved Switch: " + PlayerPrefs.GetInt("CurrentSwitch" + currentLevel));
        PlayerPrefs.SetInt("CurrentSwitch" + currentLevel, randSwitch);
        PlayerPrefs.SetInt("CurrentAnswer" + currentLevel, answer);
        
        Debug.Log("Retrieved CurrSwitch: " + PlayerPrefs.GetInt("CurrentSwitch" + currentLevel));
        Debug.Log("Retrieved CurrAnswer: " + PlayerPrefs.GetInt("CurrentAnswer" + currentLevel));
    }

    public void ChangeSprite(int index)
    {
        for (int i = 0; i < Sp_eggs.Length; i++)
        {
            if (i == index)
            {
                caterpillar.GetComponent<Image>().sprite = Sp_eggs[i];
            };
        }
    }
}
