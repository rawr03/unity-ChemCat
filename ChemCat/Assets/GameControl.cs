using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class GameControl : MonoBehaviour
{
    // Equation related
    public Equations[] problems;
    private static List<Equations> unansweredProblems;
    
    private Equations currentEquation;

    [SerializeField]
    private Text equationText1;

    [SerializeField]
    private Text equationText2;

    [SerializeField]
    private Text equationText3;

    [SerializeField]
    private Text equationText4;

    // Health related 
    public GameObject Heart1, Heart2, Heart3, Switch4, correct, gameOver;
    public static int health;


    void Start()
    {   
        health = 3;
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);
        correct.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
        //Switch4.gameObject.SetActive(false);

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

        equationText1.text = currentEquation.reactant1;
        equationText2.text = currentEquation.reactant2;
        equationText3.text = currentEquation.product1;
        equationText4.text = currentEquation.product2;
        unansweredProblems.RemoveAt(randomEquationIndex);
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
