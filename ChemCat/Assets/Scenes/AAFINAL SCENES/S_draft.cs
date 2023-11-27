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

public class S_draft : MonoBehaviour
{
    public Equations[] problems;
    private List<Equations> unansweredProblems;

    private Equations currentEquation;

    //FIELDS TO BE CHANGE
    [SerializeField]
    private int currentEquationIndex;
    public string difficulty;
    ///////////

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



    public static int PassCurrentIndex;
    public static string ElemText1, ElemText2, ElemText3, ElemText4, Diff;

    public TextMeshProUGUI showDifficulty;

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
        PassCurrentIndex = currentEquationIndex;
        LevelNum = currentEquationIndex + 1;
        Level.text = LevelNum.ToString();
        showDifficulty.text = difficulty.ToString();

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

        RecordElements(currentEquation.reactant1, currentEquation.reactant2, currentEquation.product1, currentEquation.product2, difficulty);
        RecordAnswer(equationAnswer1, equationAnswer2, equationAnswer3, equationAnswer4);
    }

    public static void RecordElements(string elem1, string elem2, string elem3, string elem4, string DiffLevel)
    {
        ElemText1 = elem1;
        ElemText2 = elem2;
        ElemText3 = elem3;
        ElemText4 = elem4;
        Diff = DiffLevel;
        Debug.Log(ElemText1);
        Debug.Log(ElemText2);
        Debug.Log(ElemText3);
        Debug.Log(ElemText4);

        //VisualsControl.SetupSprites(ElemText1, ElemText2, ElemText3, ElemText4);
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

    IEnumerator TransitionToNextLevel()
    {
        if (health == 3)
        {
            perfect.gameObject.SetActive(true); 
            AudioManager.Instance.PlaySFX("LevelComplete");
            SaveProgress();
        }
        else if (health == 2)
        {
            great.gameObject.SetActive(true);
            AudioManager.Instance.PlaySFX("LevelComplete");
            SaveProgress();
        }
        else if (health == 1)
        {
            good.gameObject.SetActive(true);
            AudioManager.Instance.PlaySFX("LevelComplete");
            SaveProgress();
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
                AudioManager.Instance.PlaySFX("Correct");
            }
            else
            {
                Debug.Log("Wrong");
                health--;
                AudioManager.Instance.PlaySFX("Wrong");
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
                AudioManager.Instance.PlaySFX("Wrong");
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
                AudioManager.Instance.PlaySFX("Wrong");
            }
        }
        // StartCoroutine(EnablePanel());
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOver.gameObject.SetActive(false);
        AudioManager.Instance.PlayMusic("BGMusic");
    }


    public void SaveProgress()
    {
        Debug.Log(difficulty);
        if(difficulty == "Easy")
        {
            if(PlayerPrefs.GetInt("LevelPassedE", 2) < LevelNum)
            {
                PlayerPrefs.SetInt("LevelPassedE", LevelNum);
                //Debug.Log(PlayerPrefs.GetInt("LevelPassedE", 2));
                Debug.Log("Saved Score: " + PlayerPrefs.GetInt("ScoreE" + LevelNum, 0));

                if(PlayerPrefs.GetInt("ScoreE" + LevelNum, 0) < health)
                {
                    PlayerPrefs.SetInt("ScoreE" + LevelNum, health);
                    Debug.Log("NewScore" + PlayerPrefs.GetInt("ScoreE" + LevelNum, 0));
                }
            }
            else
            {
                if (PlayerPrefs.GetInt("ScoreE" + LevelNum, 0) < health)
                {
                    PlayerPrefs.SetInt("ScoreE" + LevelNum, health);
                    Debug.Log("NewScore" + PlayerPrefs.GetInt("ScoreE" + LevelNum, 0));
                }
            }
            
        }
        else if (difficulty == "Medium")
        {
            if (PlayerPrefs.GetInt("LevelPassedM", 2) < LevelNum)
            {
                PlayerPrefs.SetInt("LevelPassedM", LevelNum);
                Debug.Log("Medium: " + PlayerPrefs.GetInt("LevelPassedM", 2));
                Debug.Log("Saved Score: " + PlayerPrefs.GetInt("ScoreM" + LevelNum, 0));

                if (PlayerPrefs.GetInt("ScoreM" + LevelNum, 0) < health)
                {
                    PlayerPrefs.SetInt("ScoreM" + LevelNum, health);
                    Debug.Log("NewScore" + PlayerPrefs.GetInt("ScoreM" + LevelNum, 0));
                }
            }
            else
            {
                if (PlayerPrefs.GetInt("ScoreM" + LevelNum, 0) < health)
                {
                    PlayerPrefs.SetInt("ScoreM" + LevelNum, health);
                    Debug.Log("NewScore" + PlayerPrefs.GetInt("ScoreM" + LevelNum, 0));
                }
            }
        }
        else if (difficulty == "Hard")
        {
            if (PlayerPrefs.GetInt("LevelPassedH", 2) < LevelNum)
            {
                PlayerPrefs.SetInt("LevelPassedH", LevelNum);
                //Debug.Log(PlayerPrefs.GetInt("LevelPassedH", 2));
                Debug.Log("Saved Score: " + PlayerPrefs.GetInt("ScoreH" + LevelNum, 0));

                if (PlayerPrefs.GetInt("ScoreH" + LevelNum, 0) < health)
                {
                    PlayerPrefs.SetInt("ScoreH" + LevelNum, health);
                    Debug.Log("NewScore" + PlayerPrefs.GetInt("ScoreH" + LevelNum, 0));
                }
            }
            else
            {
                if (PlayerPrefs.GetInt("ScoreH" + LevelNum, 0) < health)
                {
                    PlayerPrefs.SetInt("ScoreH" + LevelNum, health);
                    Debug.Log("NewScore" + PlayerPrefs.GetInt("ScoreH" + LevelNum, 0));
                }
            }
        }
        

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
                AudioManager.Instance.musicSource.Pause();
                StartCoroutine(TransitionToNextLevel());
                break;
        }
    }
}
