using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildEq : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject E1, E2, Input;
    string InputEq = null; 
    string genInput;
    int inputIndex = 0;
    //public List<string> EqBuild;
    //
    void Start()
    {
        //List<string> EqBuild = new ();
    }

    private void Update()
    {
         //Debug.Log(EqBuild.ToString());
    }

    public void InputElement1()
    {
        genInput = E1.GetComponentInChildren<TextMeshProUGUI>().text;
        //EqBuild[inputIndex] = genInput;
        //EqBuild.Add(genInput);
        inputIndex++;
        UpdateInput(genInput);
    }

    public void InputElement2()
    {
        genInput = E2.GetComponentInChildren<TextMeshProUGUI>().text;
        //EqBuild[inputIndex] = genInput;
        //EqBuild.Add(genInput);
        inputIndex++;
        UpdateInput(genInput);
    }

    public void UpdateInput(string genInput)
    {
        //EqBuild[inputIndex] = genInput;
        //InputEq = EqBuild[0] + EqBuild[1] + EqBuild[2] + EqBuild[3];
        //InputEq = string.Join (",", EqBuild);
        InputEq = Input.GetComponentInChildren<TextMeshProUGUI>().text;
        InputEq = InputEq + genInput;
        Input.GetComponentInChildren<TextMeshProUGUI>().text = InputEq;
    }

    /*
    public void InputSub()
    {
        genInput = sb.GetComponent<TextMeshProUGUI>().text;
        EqBuild[inputIndex] = genInput;
        inputIndex++;
    }*/

}
