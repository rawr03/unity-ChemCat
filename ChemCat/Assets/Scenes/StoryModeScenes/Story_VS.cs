using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;
using TMPro;

public class Story_VS : MonoBehaviour
{
    public GameObject E1, E2, E3, E4, E5, E6, E7, E8, E9;
    public GameObject inputNum;
    //private SpriteRenderer rend;


    public Sprite[] sprites;
    //public int CurrentIndex;
    public string Element1, Element2, Element3, Element4, Element;
    private static string Num;
    public int switchNum;
    public string difficulty;

    public void SetupSprites()
    {
        sprites = Resources.LoadAll("ALLelements", typeof(Sprite)).Cast<Sprite>().ToArray();

        /*
        difficulty = S_draft.Diff;

        if (difficulty == "Easy")
        {
            sprites = Resources.LoadAll("EasyStandardMolecules", typeof(Sprite)).Cast<Sprite>().ToArray();
        }
        else if (difficulty == "Medium")
        {
            sprites = Resources.LoadAll("MediumStandardMolecules", typeof(Sprite)).Cast<Sprite>().ToArray();
        }
        else
        {
            sprites = Resources.LoadAll("StoryModeMolecules", typeof(Sprite)).Cast<Sprite>().ToArray();
        }
        */

        ChooseSwitch();

        for (int i = 0; i < sprites.Length; i++)
        {
            if (sprites[i].name == Element)
            {
                //E1.GetComponent<SpriteRenderer>().sprite = sprites[i];
                E1.GetComponent<Image>().sprite = sprites[i];
                E2.GetComponent<Image>().sprite = sprites[i];
                E3.GetComponent<Image>().sprite = sprites[i];
                E4.GetComponent<Image>().sprite = sprites[i];
                E5.GetComponent<Image>().sprite = sprites[i];
                E6.GetComponent<Image>().sprite = sprites[i];
                E7.GetComponent<Image>().sprite = sprites[i];
                E8.GetComponent<Image>().sprite = sprites[i];
                E9.GetComponent<Image>().sprite = sprites[i];

            };
        }



    }

    public void ChooseSwitch()
    {
        Element1 = StoryControl.ElemText1;
        Element2 = StoryControl.ElemText2;
        Element3 = StoryControl.ElemText3;
        Element4 = StoryControl.ElemText4;

        if (switchNum == 1)
        {
            Element = Element1;
        }
        else if (switchNum == 2)
        {
            Element = Element2;
        }
        else if (switchNum == 3)
        {
            Element = Element3;
        }
        else if (switchNum == 4)
        {
            Element = Element4;
        }
    }

    public void Visuals()
    {
        SetupSprites();
        Num = inputNum.GetComponent<Text>().text;
        Num.Trim();

        switch (Num)
        {
            /*
             case "0":
                 E1.gameObject.SetActive(false);
                 E2.gameObject.SetActive(false);
                 E3.gameObject.SetActive(false);
                 E4.gameObject.SetActive(false);
                 E5.gameObject.SetActive(false);
                 E6.gameObject.SetActive(false);
                 E7.gameObject.SetActive(false);
                 E8.gameObject.SetActive(false);
                 E9.gameObject.SetActive(false);
            */
            case "1":
                E1.SetActive(true);
                E2.SetActive(false);
                E3.SetActive(false);
                E4.SetActive(false);
                E5.SetActive(false);
                E6.SetActive(false);
                E7.SetActive(false);
                E8.SetActive(false);
                E9.SetActive(false);
                break;


            case "2":
                E1.SetActive(true);
                E2.SetActive(true);
                E3.SetActive(false);
                E4.SetActive(false);
                E5.SetActive(false);
                E6.SetActive(false);
                E7.SetActive(false);
                E8.SetActive(false);
                E9.SetActive(false);
                break;

            case "3":
                E1.SetActive(true);
                E2.SetActive(true);
                E3.SetActive(true);
                E4.SetActive(false);
                E5.SetActive(false);
                E6.SetActive(false);
                E7.SetActive(false);
                E8.SetActive(false);
                E9.SetActive(false);
                break;

            case "4":
                E1.SetActive(true);
                E2.SetActive(true);
                E3.SetActive(true);
                E4.SetActive(true);
                E5.SetActive(false);
                E6.SetActive(false);
                E7.SetActive(false);
                E8.SetActive(false);
                E9.SetActive(false);
                break;

            case "5":
                E1.SetActive(true);
                E2.SetActive(true);
                E3.SetActive(true);
                E4.SetActive(true);
                E5.SetActive(true);
                E6.SetActive(false);
                E7.SetActive(false);
                E8.SetActive(false);
                E9.SetActive(false);
                break;

            case "6":
                E1.SetActive(true);
                E2.SetActive(true);
                E3.SetActive(true);
                E4.SetActive(true);
                E5.SetActive(true);
                E6.SetActive(true);
                E7.SetActive(false);
                E8.SetActive(false);
                E9.SetActive(false);
                break;

            case "7":
                E1.SetActive(true);
                E2.SetActive(true);
                E3.SetActive(true);
                E4.SetActive(true);
                E5.SetActive(true);
                E6.SetActive(true);
                E7.SetActive(true);
                E8.SetActive(false);
                E9.SetActive(false);
                break;

            case "8":
                E1.SetActive(true);
                E2.SetActive(true);
                E3.SetActive(true);
                E4.SetActive(true);
                E5.SetActive(true);
                E6.SetActive(true);
                E7.SetActive(true);
                E8.SetActive(true);
                E9.SetActive(false);
                break;

            case "9":
                E1.SetActive(true);
                E2.SetActive(true);
                E3.SetActive(true);
                E4.SetActive(true);
                E5.SetActive(true);
                E6.SetActive(true);
                E7.SetActive(true);
                E8.SetActive(true);
                E9.SetActive(true);
                break;
            case null:
                E1.SetActive(false);
                E2.SetActive(false);
                E3.SetActive(false);
                E4.SetActive(false);
                E5.SetActive(false);
                E6.SetActive(false);
                E7.SetActive(false);
                E8.SetActive(false);
                E9.SetActive(false);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        Visuals();
        //Debug.Log(CurrentIndex);
    }
}
