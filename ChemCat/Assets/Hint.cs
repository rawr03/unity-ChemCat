using JetBrains.Annotations;
using System.Data.Common;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] Sp_eggs;
    public GameObject heart1, heart2, heart3, caterpillar, Db_hint;
    public TextMeshProUGUI hintText;
    int index;
    int[] switchNum;
    int[] answers;
    int randIndex;
    int randSwitch;
    int answer;

    //S_draft s_Draft;
    void Start()
    {
        //s_Draft = FindObjectOfType<Canvas>().GetComponent<S_draft>();
        Sp_eggs = Resources.LoadAll<Sprite>("sp_caterpillar");
        randIndex = Random.Range(0, 3); 
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
    }

    public void showHint()
    {
        Db_hint.SetActive(true);
    }

    public void AssignValues(int answer1, int answer2, int answer3,int answer4)
    {
        switchNum = new int[4];
        switchNum[0] = 1;
        switchNum[1] = 2;
        switchNum[2] = 3;
        switchNum[3] = 4;
        //Debug.Log(switchNum.ToString());

        answers = new int[4];
        answers[0] = answer1;
        answers[1] = answer2;
        answers[2] = answer3;
        answers[4] = answer4;

        randSwitch = switchNum[randIndex];
        answer = answers[randIndex];
        //hintText.text = randSwitch.ToString() + " has the COEFFICIENT " + answer.ToString();
        //hintText.SetText("Switch {0} + has the COEFFICIENT + {1}.", randSwitch, answer);
        Debug.Log(randSwitch);
        Debug.Log(answer);
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
