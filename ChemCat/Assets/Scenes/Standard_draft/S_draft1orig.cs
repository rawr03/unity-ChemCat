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

public class S_draft1orig : MonoBehaviour
{
    public Equations[] problems;
    private static List<Equations> unansweredProblems;

    private Equations currentEquation;

    // display Text of Equation Problem
    [SerializeField]
    private TextMeshProUGUI equationText1;

    [SerializeField]
    private TextMeshProUGUI equationText2;

    [SerializeField]
    private TextMeshProUGUI equationText3;

    [SerializeField]
    private TextMeshProUGUI equationText4;

    [SerializeField]
    private float timeBetweenEquations = 1f;

    [SerializeField]
    private int currentEquationIndex;


    
    public TextMeshProUGUI Level;

    // Pop ups
    public GameObject Switch1, Switch4, gameOver, perfect, great, good;

    // Reactants and Products
    public static int equationAnswer1, equationAnswer2, equationAnswer3, equationAnswer4;
   
    // respawn problem
    public static int health;

    // Life related
    public GameObject Heart1, Heart2, Heart3;
    public static float startTime;

    // Coefficients 
    public GameObject inputNum1, inputNum2, inputNum3, inputNum4;

    public static int LevelNum;
    private static string Num1, Num2, Num3, Num4;
    public static int React1, React2, Prod1, Prod2;
    public static string Element1, Element2, Element3, Element4;


    void Start()
    {
        // set health to 3, and all hearts must be set active
        health = 3;

        LevelNum = currentEquationIndex + 1;
        Level.text = LevelNum.ToString();

        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);

        // Switch1, Switch4, correct, wrong and gameOver must be set to false by default
        Switch1.gameObject.SetActive(false);
        Switch1.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);

        // hide floating docks
        perfect.gameObject.SetActive(false);
        great.gameObject.SetActive(false);
        good.gameObject.SetActive(false);

        if (unansweredProblems == null || unansweredProblems.Count == 0)
        {
            unansweredProblems = problems.ToList<Equations>();
        }

        GetRandomEquation();
        // call to get random Equation
    }



    public void GetRandomEquation()
    {
        // take random index
        // int randomEquationIndex = Random.Range(0, unansweredProblems.Count);
        currentEquation = unansweredProblems[currentEquationIndex];

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

        Debug.Log(equationAnswer1 + " " + equationAnswer2 + " " + equationAnswer3 + " " + equationAnswer4);

        // activate switch based on the Problem
        if (equationAnswer1 != 0 && equationAnswer4 == 0)
        {
            Switch1.gameObject.SetActive(true);
            Switch4.gameObject.SetActive(false);
        }
        else if (equationAnswer4 != 0 && equationAnswer1 == 0)
        {
            Switch1.gameObject.SetActive(false);
            Switch4.gameObject.SetActive(true);
        }
        else
        {
            Switch1.gameObject.SetActive(true);
            Switch4.gameObject.SetActive(true);
        }

        RecordAnswer(equationAnswer1, equationAnswer2, equationAnswer3, equationAnswer4);
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
        Debug.Log("Answers: " + Element1 + " + " + Element2 + " -> " + Element3 + " + " + Element4);
    }

    /*
    IEnumerator TransitionToNextProblem()
    {
        // Remove current spawned problem from the list
        unansweredProblems.Remove(currentEquation);
        yield return new WaitForSeconds(timeBetweenEquations);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(NextLevel.buildIndex);
    }
    */

    IEnumerator TransitionToNextLevel()
    {
        if (health == 3)
        {
            perfect.gameObject.SetActive(true);
        }
        else if (health == 2)
        {
            great.gameObject.SetActive(true);
        }
        else if (health == 1)
        {
            good.gameObject.SetActive(true);
        }
        yield return new WaitForSeconds(timeBetweenEquations);
    }


    public void CheckAnswer()
    {
        Num1 = inputNum1.GetComponent<Text>().text;
        Num2 = inputNum2.GetComponent<Text>().text;
        Num3 = inputNum3.GetComponent<Text>().text;
        Num4 = inputNum4.GetComponent<Text>().text;

        Num1.Trim();
        Num2.Trim();
        Num3.Trim();
        Num4.Trim();
        Debug.Log("Input: " + Num1 + ", " + Num2 + ", " + Num3 + ", " + Num4);

        if (Element4 == "0")
        {
            if (Num1.Equals(Element1) && Num2.Equals(Element2) && Num3.Equals(Element3))
            {
                Debug.Log("Correct");
                StartCoroutine(TransitionToNextLevel());
            }
            else
            {
                Debug.Log("Wrong");
                health--;
            }
        }
        else if (Element1 == "0")
        {
            if (Num2.Equals(Element2) && Num3.Equals(Element3) && Num4.Equals(Element4))
            {
                Debug.Log("Correct");
                StartCoroutine(TransitionToNextLevel());
            }
            else
            {
                Debug.Log("Wrong");
                health--;
            }
        }
        else
        {
            if (Num1.Equals(Element1) && Num2.Equals(Element2) && Num3.Equals(Element3) && Num4.Equals(Element4))
            {
                Debug.Log("Correct");
                StartCoroutine(TransitionToNextLevel());

            }
            else
            {
                Debug.Log("Wrong");
                health--;
            }
        }
        // StartCoroutine(EnablePanel());
    }

    

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
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
                StartCoroutine(TransitionToNextLevel());
                break;
        }
    }
}
