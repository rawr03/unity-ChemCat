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
    public GameObject Switch4, correct, wrong, gameOver;
    public static int equationAnswer1, equationAnswer2, equationAnswer3, equationAnswer4;

    // respawn problem
    public static int health; 

    void Start()
    {
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

    public void GetRandomEquation()
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
    }

    // Update is called once per frame
    void Update()
    {
        health = Confirm.health; 
    }
}
