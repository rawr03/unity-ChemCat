using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

public class GameControl : MonoBehaviour
{
    /*
    // Switch related
    public Text CurrentNum;
    public int number = 1;
    public GameObject plus;
    public GameObject minus;
    */

    // Equation related
    public Equations[] problems;
    private static List<Equations> unansweredProblems;
    
    private Equations currentEquation;

    // display Text of Equation Problem
    [SerializeField]
    private Text equationText1;

    [SerializeField]
    private Text equationText2;

    [SerializeField]
    private Text equationText3;

    [SerializeField]
    private Text equationText4;


    // Health related 
    public GameObject Heart1, Heart2, Heart3, Switch4, correct, wrong, gameOver;
    public static int health;
    public static int equationAnswer1, equationAnswer2, equationAnswer3, equationAnswer4;
    
    // Confirm Button related
    public static int Num1, Num2, Num3, Num4;
    public GameObject inputNum1, inputNum2, inputNum3;
    void Start()
    {

        health = 3;
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);
        Switch4.gameObject.SetActive(false);
        correct.gameObject.SetActive(false);
        wrong.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
        if (unansweredProblems == null || unansweredProblems.Count == 0)
        {
            unansweredProblems = problems.ToList<Equations>();
        }

        GetRandomEquation();
        
    }

    void GetRandomEquation()
    {
        int randomEquationIndex = Random.Range(0, unansweredProblems.Count);
        currentEquation = unansweredProblems[randomEquationIndex];

        // equation Text displayed
        equationText1.text = currentEquation.reactant1;
        equationText2.text = currentEquation.reactant2;
        equationText3.text = currentEquation.product1;
        equationText4.text = currentEquation.product2;

        // answer coefficients for spawned problem
        equationAnswer1 = currentEquation.RT_coef1;
        equationAnswer2 = currentEquation.RT_coef2;
        equationAnswer3 = currentEquation.PD_coef1;
        equationAnswer4 = currentEquation.PD_coef2;

        // Remove index of spawned problem from the list
        unansweredProblems.RemoveAt(randomEquationIndex);

        Confirm.RecordAnswer(equationAnswer1, equationAnswer2, equationAnswer3, equationAnswer4);
        //  Confirm(equationAnswer1, equationAnswer2, equationAnswer3, equationAnswer4);
    }

    /*
    void Confirm(int equationAnswer1, int equationAnswer2, int equationAnswer3, int equationAnswer4)
    {
        Num1 = inputNum1.;
        Num2 = inputNum2.GetComponent<int>();
        Num3 = inputNum3.GetComponent<int>();

        Debug.Log(equationAnswer1 + equationAnswer2 + equationAnswer3 + equationAnswer4);
        Debug.Log(Num1);
        Debug.Log(Num2);
        Debug.Log(Num3);
        // Num4 = inputNum1.GetComponent<int>();

    if (Num1 == equationAnswer1 && Num2 == equationAnswer2 && Num3 == equationAnswer3)
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
    */

    /* Add/Subtract
    public void Add()
    {
        number++;
        CurrentNum.text = number.ToString();
    }

    public void Subract()
    {
        if (number > 1)
        {
            number--;
            CurrentNum.text = number.ToString();
        }

    }
*/
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
