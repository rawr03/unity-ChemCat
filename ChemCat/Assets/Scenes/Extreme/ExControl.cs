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

    // Reactants and Products
    public GameObject E1, E2, E3, E4, InputEq; //good, great, perfect;
    
    public static int equationAnswer1, equationAnswer2, equationAnswer3, equationAnswer4;
    public static int React1, React2, Prod1, Prod2;
    
    public static string Element1, Element2, Element3, Element4;
    public string answerEq;
    //private static string Num1, Num2, Num3, Num4;
    string builtEq;

    BuildEq bEq;

    // respawn problem
    public static int health;
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

        // answer coefficients for spawned problem
        //equationAnswer1 = currentEquation.RT_coef1;
        //equationAnswer2 = currentEquation.RT_coef2;
        //equationAnswer3 = currentEquation.PD_coef1;
        //equationAnswer4 = currentEquation.PD_coef2;

        Debug.Log(equationAnswer1 + " " + equationAnswer2 + " " + equationAnswer3 + " " + equationAnswer4);
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
        Debug.Log("Answers: " + Element1 + " + " + Element2 + " -> " + Element3 + " + " + Element4);
    }
    void Start()
    {
        bEq = FindObjectOfType<BuildEq>();
        if (unansweredProblems == null || unansweredProblems.Count == 0)
        {
            unansweredProblems = problems.ToList<ExEquations>();
        }
        GetRandomEquation();
    }

    /*
    IEnumerator TransitionToNextLevel()
    {
        if (health == 3)
        {
            perfect.SetActive(true);
            //AudioManager.Instance.PlaySFX("LevelComplete");
            //SaveProgress();
        }
        else if (health == 2)
        {
            great.SetActive(true);
            //AudioManager.Instance.PlaySFX("LevelComplete");
            //SaveProgress();
        }
        else if (health == 1)
        {
            good.SetActive(true);
            //AudioManager.Instance.PlaySFX("LevelComplete");
            //SaveProgress();
        }
        yield return new WaitForSeconds(timeBetweenEquations);
    } */


    public void CheckAnswer()
    {
        // Get input Eq by player
        builtEq = InputEq.GetComponent<TextMeshProUGUI>().text;
        builtEq = builtEq.Trim();

        answerEq = currentEquation.product1;

        Debug.Log("Input: " + builtEq);
        Debug.Log("Answer: " + answerEq);

        if (builtEq.Equals(answerEq))
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Wrong");
        }

        //StartCoroutine(TransitionToNextLevel());

        /*
        if (Element4 == "0")
        {
            if (Num1.Equals(Element1) && Num2.Equals(Element2) && Num3.Equals(Element3))
            {
                Debug.Log("Correct");
                StartCoroutine(TransitionToNextLevel());
                AudioManager.Instance.PlaySFX("Correct");
            }
            else
            {
                Debug.Log("Wrong");
                health--;
                //AudioManager.Instance.PlaySFX("Wrong");
            }
        }
        else if (Element1 == "0")
        {
            if (Num2.Equals(Element2) && Num3.Equals(Element3) && Num4.Equals(Element4))
            {
                Debug.Log("Correct");
                StartCoroutine(TransitionToNextLevel());
                AudioManager.Instance.PlaySFX("Correct");
            }
            else
            {
                Debug.Log("Wrong");
                health--;
                //AudioManager.Instance.PlaySFX("Wrong");
            }
        }
        else
        {
            if (Num1.Equals(Element1) && Num2.Equals(Element2) && Num3.Equals(Element3) && Num4.Equals(Element4))
            {
                Debug.Log("Correct");
                StartCoroutine(TransitionToNextLevel());
                AudioManager.Instance.PlaySFX("Correct");
            }
            else
            {
                Debug.Log("Wrong");
                health--;

            }
        } */
        // StartCoroutine(EnablePanel());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
