using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class ExControl : MonoBehaviour
{

    public ExEquations[] problems;
    private List<ExEquations> unansweredProblems;

    private ExEquations currentEquation;

    [SerializeField]
    private TextMeshProUGUI Reactants;

    //FIELDS TO BE CHANGE
    [SerializeField]
    private int currentEquationIndex;

    [SerializeField]
    private TextMeshProUGUI equationText1;

    [SerializeField]
    private TextMeshProUGUI equationText2;

    [SerializeField]
    private TextMeshProUGUI equationText3;

    [SerializeField]
    private TextMeshProUGUI equationText4;

    [SerializeField]
    private TextMeshProUGUI equationSub1;

    [SerializeField]
    private TextMeshProUGUI equationSub2;

    [SerializeField]
    private TextMeshProUGUI equationSub3;

    [SerializeField]
    private TextMeshProUGUI equationSub4;

    [SerializeField]
    private float timeBetweenEquations = 1f;

    // health
    public GameObject heart1, heart2, heart3, gameOver;

    // Reactants and Products
    public GameObject E1, E2, E3, E4, InputEq, Input2, Input2_1, Input2_2, Em, Em2; //good, great, perfect;
    
    public static int equationAnswer1, equationAnswer2, equationAnswer3, equationAnswer4;
    public static int React1, React2, Prod1, Prod2;
    
    public static string Element1, Element2, Element3, Element4;
    public string answerEq;
    //private static string Num1, Num2, Num3, Num4;
    string builtEq, builtEq2;

    BuildEq bEq;

    // respawn problem
    public static int health = 3;

    //string genInput;

    // Start is called before the first frame update

    public void GetRandomEquation()
    {
        currentEquation = unansweredProblems[currentEquationIndex];

        Reactants.text = currentEquation.Equation;

        // equation Text displayed
        equationText1.text = currentEquation.reactant1;
        equationText2.text = currentEquation.reactant2;
        equationText3.text = currentEquation.product1;
        equationText4.text = currentEquation.product2;

        equationSub1.text = currentEquation.RT_sub1;
        equationSub2.text = currentEquation.RT_sub2;
        equationSub3.text = currentEquation.PD_sub1;
        equationSub4.text = currentEquation.PD_sub2;

        bEq.HideElements(currentEquation.reactant1, currentEquation.reactant2, currentEquation.product1, currentEquation.product2);
        /*
        // activate switch based on the Problem
        if (equationAnswer1 != 0 && equationAnswer4 == 0)
        {
            E1.SetActive(true);
            E4.SetActive(false);
        }
        else if (equationAnswer4 != 0 && equationAnswer1 == 0)
        {
            E1.SetActive(false);
            E4.SetActive(true);
        }
        else
        {
            E1.SetActive(true);
            E4.SetActive(true);
        }*/
        //RecordAnswer(equationAnswer1, equationAnswer2, equationAnswer3, equationAnswer4);
    }

    public static void RecordAnswer(int equationAnswer1, int equationAnswer2, int equationAnswer3, int equationAnswer4)
    {
        React1 = equationAnswer1;
        React2 = equationAnswer2;
        Prod1 = equationAnswer3;
        Prod2 = equationAnswer4;

        Element1 = React1.ToString();
        Element2 = React2.ToString();
        Element3 = Prod1.ToString();
        Element4 = Prod2.ToString();

        // yes data is transferred
        //Debug.Log("Answers: " + Element1 + " + " + Element2 + " -> " + Element3 + " + " + Element4);
    }
    void Start()
    {
        health = 3;
        Em.SetActive(true);
        Em2.SetActive(false);

        InputEq.SetActive(false);
        Input2.SetActive(false);

        bEq = FindObjectOfType<BuildEq>();
        if (unansweredProblems == null || unansweredProblems.Count == 0)
        {
            unansweredProblems = problems.ToList<ExEquations>();
        }
        GetRandomEquation();

        if (E3.activeSelf == false && E4.activeSelf == false)
        {
            Input2.SetActive(false);
            InputEq.SetActive(true);
        }
        else //if (E3.activeSelf == true && E4.activeSelf == true)
        {
            InputEq.SetActive(false);
            Input2.SetActive(true);
        }

    }

    public void CheckAnswer()
    {
        // Get input Eq by player
        if(E1.activeSelf == true && E2.activeSelf == true && E3.activeSelf == false && E4.activeSelf == false)
        {
            builtEq = InputEq.GetComponentInChildren<TextMeshProUGUI>().text;
            builtEq = builtEq.Trim();
            answerEq = currentEquation.Answer;

            Debug.Log("Input: " + builtEq);
            Debug.Log("Answer: " + answerEq);

            if (builtEq.Equals(answerEq))
            {
                Debug.Log("Correct!");
                Em.SetActive(false);
                Em2.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
                health--;
            }
        }
        else
        {
            builtEq = Input2_1.GetComponentInChildren<TextMeshProUGUI>().text + " + " + Input2_2.GetComponentInChildren<TextMeshProUGUI>().text;
            builtEq2 = Input2_2.GetComponentInChildren<TextMeshProUGUI>().text + " + " + Input2_1.GetComponentInChildren<TextMeshProUGUI>().text;
            answerEq = currentEquation.Answer;

            Debug.Log("Input: " + builtEq + " or " + builtEq2);
            Debug.Log("Answer: " + answerEq);

            if (builtEq.Equals(answerEq) || builtEq2.Equals(answerEq))
            {
                Debug.Log("Correct!");
                Em.SetActive(false);
                Em2.SetActive(true);
            }
            else
            {
                Debug.Log("Wrong");
                health--;
            }
        }

        
 
    }

    public void Update()
    {
        if (health == 3)
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(true);
        }
        else if (health == 2)
        {
            heart1.SetActive(true);
            heart2.SetActive(true);
            heart3.SetActive(false);
        }
        else if (health == 1)
        {
            heart1.SetActive(true);
            heart2.SetActive(false);
            heart3.SetActive(false);
        }
        else if(health == 0)
        {
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
            gameOver.SetActive(true);
        }
    }

}

