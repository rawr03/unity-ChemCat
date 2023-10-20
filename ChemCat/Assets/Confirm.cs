using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Confirm : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject correct, wrong, gameOver;
    public GameObject inputNum1, inputNum2, inputNum3; //inputNum4;
 
    private static string Num1, Num2, Num3; //Num4;
    public static int React1, React2, Prod1;
    public static string Element1, Element2, Element3, Element4;

    // Life related
    public GameObject Heart1, Heart2, Heart3;
    public static int health;

    private void Start()
    {
        health = 3;
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);
    }

    public static void RecordAnswer(int equationAnswer1, int equationAnswer2, int equationAnswer3, int equationAnswer4)
    {
        React1 = equationAnswer1;
        React2 = equationAnswer2;
        Prod1 = equationAnswer3;
        
        Element1 = React1.ToString();
        Element2 = React2.ToString();
        Element3 = Prod1.ToString();

        // yes data is transferred
        Debug.Log("Answers: " + Element1 + " + " + Element2 + " -> " + Element3);
        // Num4 = inputNum1.GetComponent<int>();     
        
    }

    public void CheckAnswer()
    {
        Num1 = inputNum1.GetComponent<Text>().text;
        Num2 = inputNum2.GetComponent<Text>().text;
        Num3 = inputNum3.GetComponent<Text>().text;

        Num1.Trim();
        Num2.Trim();
        Num3.Trim();

        Debug.Log("Input: " + Num1 + ", " + Num2 + ", " + Num3);
        if (Num1.Equals(Element1) && Num2.Equals(Element2) && Num3.Equals(Element3))
        {
            Debug.Log("Correct");
            correct.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("Wrong");
            //wrong.gameObject.SetActive(true);
            health--;
        }
        
        // GameControl.GetRandomEquation();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {
            case 3:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(true);
                break;
            case 2:
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(true);
                break;
            case 1:
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(true);
                break;
            case 0:
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                break;
        }
    }
}