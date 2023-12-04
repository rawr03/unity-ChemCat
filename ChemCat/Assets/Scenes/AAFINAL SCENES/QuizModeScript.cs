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

public class QuizModeScript : MonoBehaviour
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
