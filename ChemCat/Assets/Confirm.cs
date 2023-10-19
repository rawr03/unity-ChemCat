using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Confirm : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject correct, wrong;
    public GameObject inputNum1, inputNum2, inputNum3; //inputNum4;
 
    private static string Num1, Num2, Num3; //Num4;
    public static int React1, React2, Prod1;

    private void Start()
    {

    }

    public static void RecordAnswer(int equationAnswer1, int equationAnswer2, int equationAnswer3, int equationAnswer4)
    {
        React1 = equationAnswer1;
        React2 = equationAnswer2;
        Prod1 = equationAnswer3;

        
        // yes data is transferred
        Debug.Log("Answers are " + React1 + " + " + React1 + " -> " + Prod1);
        // Num4 = inputNum1.GetComponent<int>();     
        
    }

    public void CheckAnswer()
    {
        Num1 = inputNum1.GetComponent<Text>().text;
        Num2 = inputNum2.GetComponent<Text>().text;
        Num3 = inputNum3.GetComponent<Text>().text;

        Debug.Log("Input are " + Num1 + ", " + Num2 + ", " + Num3);

        
        if (Num1.Equals(React1.ToString()) && Num2.Equals(React2.ToString()) && Num3.Equals(Prod1.ToString()))
        {
            Debug.Log("Correct");
            //correct.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("Wrong");
            //gameOver.gameObject.SetActive(true);
        }
        
    }
    
    // Update is called once per frame
    void Update()
    {
 
    }
    

}
