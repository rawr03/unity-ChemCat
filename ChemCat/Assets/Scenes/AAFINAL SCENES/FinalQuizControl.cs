using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class QuizControl : MonoBehaviour
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
    private float timeBetweenEquations = .01f;

    // anim
    public TextMeshProUGUI addtnlTime;
    //private Animator anim;

    // Timer
    public float time = 0f;
    public int minutes = 0;
    public int seconds = 0;
    public string textTime;

    public int gameScore;

    /*
    public Slider timerSlider;
    public float sliderTimer;
    public bool stopTimer = false;
    */


    // Timer & Score
    public Slider timerSlider;
    public Text timerText;
    public float gameTime;
    private bool stopTimer;
    private float Maxtime;
    public float addTime;
    public float elapsedTime;
    public static float UsedTime;


    // Health related 
    public GameObject Switch1, Switch4, gameOver, newHighscore;
    public static int equationAnswer1, equationAnswer2, equationAnswer3, equationAnswer4;

    //PopUp
    public static int Highscore;
    public Text GameOver_Score;
    public Text GameOver_HighscoreDisplay;
    public Text Highscore_Score;
    public Text Highscore_HighscoreDisplay;

    // respawn problem
    public static int health;
    public Text GameScoreDisplay;
    public static int CurrScore;

    // Life related
    public GameObject Heart1, Heart2, Heart3;
    public static float startTime;

    // Start is called before the first frame update
    public GameObject inputNum1, inputNum2, inputNum3, inputNum4;

    private static string Num1, Num2, Num3, Num4;
    public static int React1, React2, Prod1, Prod2;
    public static string Element1, Element2, Element3, Element4;

    // Reset Switch
    public GameObject Switch2, Switch3;

    void Start()
    {
        //anim = GetComponent<Animator>();
        //settings.gameObject.SetActive(false);
        addtnlTime.gameObject.SetActive(false);

        //Setup for Time
        //Maxtime = 180;
        gameTime = 180;
        stopTimer = false;
        timerSlider.maxValue = gameTime; //Maxtime;
        timerSlider.value = time; //gameTime;
        //gameTime = 180 - UsedTime;
        Debug.Log(UsedTime);
        // gameTime = 180f;

        // set health to 3, and all hearts must be set active
        health = 3;
        CurrScore = gameScore + CurrScore;
        addTime = 0;
        GameScoreDisplay.text = CurrScore.ToString();
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);

        // Switch1, Switch4, correct, wrong and gameOver must be set to false by default
        Switch1.gameObject.SetActive(false);
        Switch4.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
        newHighscore.gameObject.SetActive(false);

        if (unansweredProblems == null || unansweredProblems.Count == 0)
        {
            unansweredProblems = problems.ToList<Equations>();
        }

        // call to get random Equation
        GetRandomEquation();
    }


    public void GetRandomEquation()
    {
        // take random index
        int randomEquationIndex = Random.Range(0, unansweredProblems.Count);
        currentEquation = unansweredProblems[randomEquationIndex];
        addTime = 0;
        health = 3;

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

        addtnlTime.text = "+" + currentEquation.addtnlTime.ToString();
        RecordAnswer(equationAnswer1, equationAnswer2, equationAnswer3, equationAnswer4);
        
        Switch1.GetComponent<GamePlayFunctionalities>().number = 1;
        Switch2.GetComponent<GamePlayFunctionalities>().number = 1;
        Switch3.GetComponent<GamePlayFunctionalities>().number = 1;
        Switch4.GetComponent<GamePlayFunctionalities>().number = 1;
        inputNum1.GetComponent<Text>().text = "1";
        inputNum2.GetComponent<Text>().text = "1";
        inputNum3.GetComponent<Text>().text = "1";
        inputNum4.GetComponent<Text>().text = "1";
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

    IEnumerator TransitionToNextProblem()
    {
        addtnlTime.gameObject.SetActive(false);
        addtnlTime.gameObject.SetActive(true);

        // Remove current spawned problem from the list
        unansweredProblems.Remove(currentEquation);
        yield return new WaitForSeconds(timeBetweenEquations);

        if (unansweredProblems == null)
        {
            gameScore = CurrScore;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            GetRandomEquation();
        }
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void CheckAnswer()
    {
        //addtnlTime.gameObject.SetActive(false);

        Num1 = inputNum1.GetComponent<Text>().text;
        Num2 = inputNum2.GetComponent<Text>().text;
        Num3 = inputNum3.GetComponent<Text>().text;
        Num4 = inputNum4.GetComponent<Text>().text;

        Num1.Trim();
        Num2.Trim();
        Num3.Trim();
        Num4.Trim();
        Debug.Log("Input: " + Num1 + ", " + Num2 + ", " + Num3 + ", " + Num4);

        if (equationAnswer1 != 0 && equationAnswer4 != 0)
        {
            if (Num1.Equals(Element1) && Num2.Equals(Element2) && Num3.Equals(Element3) && Num4.Equals(Element4))
            {
                addTime = currentEquation.addtnlTime;
                Debug.Log(addTime);
                Debug.Log("Correct");
                StartCoroutine(TransitionToNextProblem());
                CurrScore++;
                GameScoreDisplay.text = CurrScore.ToString();
                AudioManager.Instance.PlaySFX("Correct");
                //addtnlTime.text = "+" + currentEquation.addtnlTime.ToString();
                Debug.Log(currentEquation.addtnlTime);
            }
            else
            {
                Debug.Log("Wrong");
                health--;
                AudioManager.Instance.PlaySFX("Wrong");
                Debug.Log(currentEquation.addtnlTime);
            }
        }
        else if (equationAnswer1 != 0 && equationAnswer4 == 0)
        {
            if (Num1.Equals(Element1) && Num2.Equals(Element2) && Num3.Equals(Element3))
            {
                addTime = currentEquation.addtnlTime;
                Debug.Log(addTime);
                Debug.Log("Correct");
                StartCoroutine(TransitionToNextProblem());
                CurrScore++;
                GameScoreDisplay.text = CurrScore.ToString();
                AudioManager.Instance.PlaySFX("Correct");
                //addtnlTime.text = "+" + currentEquation.addtnlTime.ToString();
                Debug.Log(currentEquation.addtnlTime);
            }
            else
            {
                Debug.Log("Wrong");
                health--;
                AudioManager.Instance.PlaySFX("Wrong");
                Debug.Log(currentEquation.addtnlTime);

            }
        }
        else if (equationAnswer1 == 0 && equationAnswer4 != 0)
        {
            if (Num2.Equals(Element2) && Num3.Equals(Element3) && Num4.Equals(Element4))
            {
                // anim.SetBool("Correct", true);
                addTime = currentEquation.addtnlTime;
                Debug.Log(addTime);
                Debug.Log("Correct");
                StartCoroutine(TransitionToNextProblem());
                CurrScore++;
                GameScoreDisplay.text = CurrScore.ToString();
                AudioManager.Instance.PlaySFX("Correct");
                //addtnlTime.text = "+" + addTime.ToString();
                Debug.Log(currentEquation.addtnlTime);
            }
            else
            {
                Debug.Log("Wrong");
                health--;
                AudioManager.Instance.PlaySFX("Wrong");
                Debug.Log(currentEquation.addtnlTime);
            }
        }

        // StartCoroutine(EnablePanel());
    }

    void CheckHighscore()
    {
        if (CurrScore > Highscore)
        {
            newHighscore.gameObject.SetActive(true);
            Highscore = CurrScore;
            Highscore_Score.text = Highscore.ToString();
            Highscore_HighscoreDisplay.text = CurrScore.ToString();
        }
        else
        {
            gameOver.gameObject.SetActive(true);
            GameOver_Score.text = CurrScore.ToString();
            GameOver_HighscoreDisplay.text = Highscore.ToString();
        }
    }

    public void Retry()
    {
        Debug.Log("Retry");
        CurrScore = 0;
        UsedTime = 0f;   
        gameTime = 180f;
        time = gameTime;
        //Debug.Log(time);
        newHighscore.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        AudioManager.Instance.PlayMusic("BGMusic");

    }

    public void IntlzdAftEXIT()
    {
        Maxtime = 180f;
        UsedTime = 0;
        CurrScore = 0;
        gameTime = 180f;
        time = gameTime;
    }


    
/*
public void Countdown()
{
    // StartCoroutine(StarttheTimeTicker());
    //timer

}
*/

/*
IEnumerator StarttheTimeTicker()
{
    while (stopTimer = false)
    {
        sliderTimer -= time.deltaTime;
        yield return new waitforseconds(0.001f);

        if (sliderTimer <= 0)
        {
            stopTimer = true;
        }

        if (stopTimer == false)
        {
            timerSlider.value = sliderTimer;
        }
    }

}

public void StopTimer()
{
    stopTimer = true;
}
*/

// Update is called once per frame
void Update()
    {
        time = time + addTime;
        elapsedTime += Time.deltaTime;
        time = gameTime - elapsedTime;
        //UsedTime = 180 - time;
        // Debug.Log(time);
        minutes = Mathf.FloorToInt(time / 60);
        seconds = Mathf.FloorToInt(time - minutes * 60f);
        textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        if (time <= 0)
        {
            stopTimer = true;
            CheckHighscore();
        }

        if (stopTimer == false)
        {
            timerText.text = textTime;
            timerSlider.value = time;
        }

        /*
        if (settings.gameObject.active || gameOver.gameObject.active)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
        */

        //Health
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
                stopTimer = true;
                CheckHighscore();
                //AudioManager.Instance.PlaySFX("GameOver"); 
                break;
        }
    }
}