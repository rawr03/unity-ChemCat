using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExControl : MonoBehaviour
{

    public ExEquations[] problems;
    private List<Equations> unansweredProblems;

    private ExEquations currentEquation;

    //FIELDS TO BE CHANGE
    [SerializeField]
    private int currentEquationIndex;
    public string difficulty;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
