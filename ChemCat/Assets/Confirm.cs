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
    public static Text Num1, Num2, Num3; //Num4;
    public static int React1, React2, Prod1;

    private void Start()
    {

    }

    public static void RecordAnswer(int equationAnswer1, int equationAnswer2, int equationAnswer3, int equationAnswer4)
    {
        React1 = equationAnswer1;
        React2 = equationAnswer2;
        Prod1 = equationAnswer3;

        /*
        // yes data is transferred
        Debug.Log(equationAnswer1);
        Debug.Log(equationAnswer2);
        Debug.Log(equationAnswer3);
        // Num4 = inputNum1.GetComponent<int>();     
        */
    }

    public void CheckAnswer()
    {
        //  HingeJoint hinge = otherGameObject.GetComponent("HingeJoint") as HingeJoint;
        Num1.text = GetComponent<Text>().text;
        Num2.text = GetComponent<Text>().text;
        Num3.text = GetComponent<Text>().text;
        Debug.Log(Num1);
        Debug.Log(Num2.text);
        Debug.Log(Num3.text);
        /*
        if (React1.Equals(Num1) && React2.Equals(Num2) && Prod1.Equals(Num3))
        {
            Debug.Log("Correct");
            //correct.gameObject.SetActive(true);
        }
        else
        {
            Debug.Log("Wrong");
            //gameOver.gameObject.SetActive(true);
        }

        */
    }
    /*
    // Update is called once per frame
    void Update()
    {
        
    }
    */

}
