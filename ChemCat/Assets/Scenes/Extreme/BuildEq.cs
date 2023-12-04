using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildEq : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject E1, E2, E3, E4, Input;
    string InputEq = null; 
    string genInput;
    int inputIndex = 0;
    //ExControl exC;
    //public List<string> EqBuild;
    //
    void Start()
    {
        E1.SetActive(false);
        E2.SetActive(false);
        E3.SetActive(false);    
        E4.SetActive(false);
        //exC = FindObjectOfType<Canvas>().GetComponent<ExControl>();
        //List<string> EqBuild = new ();
    }

    public void HideElements(string element1, string element2, string element3, string element4)
    {
        if(element1 != null)
        {
            E1.SetActive(true);
        }

        if(element2 != null)
        {
            E2.SetActive(true);
        }
        
        if(element3 != null)
        {
            E3.SetActive(true);
        }

        if (element4 != null)
        {
            E4.SetActive(true);
        }
    }


    private void Update()
    {
         //Debug.Log(EqBuild.ToString());
    }

    public void InputElement1()
    {
        genInput = E1.GetComponentInChildren<TextMeshProUGUI>().text;
        inputIndex++;
        UpdateInput(genInput);
    }

    public void InputElement2()
    {
        genInput = E2.GetComponentInChildren<TextMeshProUGUI>().text;
        inputIndex++;
        UpdateInput(genInput);
    }
    public void InputElement3()
    {
        genInput = E3.GetComponentInChildren<TextMeshProUGUI>().text;
        inputIndex++;
        UpdateInput(genInput);
    }

    public void InputElement4()
    {
        genInput = E4.GetComponentInChildren<TextMeshProUGUI>().text;
        inputIndex++;
        UpdateInput(genInput);
    }

    public void UpdateInput(string genInput)
    {
        InputEq = Input.GetComponentInChildren<TextMeshProUGUI>().text;
        InputEq = InputEq + genInput;
        Input.GetComponentInChildren<TextMeshProUGUI>().text = InputEq;
    }

}
