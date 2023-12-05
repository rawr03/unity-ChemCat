using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuildEq : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject E1, E2, E3, E4, Input, Input2_1, Input2_2;
    string InputEq = null;
    string genInput;
    //int inputIndex = 0;
    GameObject activeInput;

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
        if (string.IsNullOrWhiteSpace(element1) == false)
        {
            E1.SetActive(true);
        }

        if (string.IsNullOrWhiteSpace(element2) == false)
        {
            E2.SetActive(true);
        }

        if (string.IsNullOrWhiteSpace(element3) == false)
        {
            E3.SetActive(true);
        }

        if (string.IsNullOrWhiteSpace(element4) == false)
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
        UpdateInput(genInput);
    }

    public void InputElement2()
    {
        genInput = E2.GetComponentInChildren<TextMeshProUGUI>().text;
        UpdateInput(genInput);
    }
    public void InputElement3()
    {
        genInput = E3.GetComponentInChildren<TextMeshProUGUI>().text;
        UpdateInput(genInput);
    }

    public void InputElement4()
    {
        genInput = E4.GetComponentInChildren<TextMeshProUGUI>().text;
        UpdateInput(genInput);
    }

    public void UpdateInput(string genInput)
    {
        if (Input.activeSelf == true)
        {
            InputEq = Input.GetComponentInChildren<TextMeshProUGUI>().text;
            InputEq = InputEq + genInput;
            Input.GetComponentInChildren<TextMeshProUGUI>().text = InputEq;
        }
        else if(Input2_1.activeSelf == true || Input2_2.activeSelf == true)
        {
            if(activeInput == Input2_1)
            {
                InputEq = Input2_1.GetComponentInChildren<TextMeshProUGUI>().text;
                InputEq = InputEq + genInput;
                Input.GetComponentInChildren<TextMeshProUGUI>().text = InputEq;
            }
            else if (activeInput == Input2_2)
            {
                InputEq = Input2_2.GetComponentInChildren<TextMeshProUGUI>().text;
                InputEq = InputEq + genInput;
                Input.GetComponentInChildren<TextMeshProUGUI>().text = InputEq;
            }

        }
    }

    public void InputThis2_1()
    {
        Input = Input2_1;
        activeInput = Input2_1;
    }

    public void InputThis2_2()
    {
        Input = Input2_2;
        activeInput = Input2_2;
    }

    public void BackSpace()
    {
        if (E3.activeSelf == false && E4.activeSelf == false)
        {
            genInput = Input.GetComponentInChildren<TextMeshProUGUI>().text;
            genInput = genInput.Remove(genInput.Length - 1);
            Input.GetComponentInChildren<TextMeshProUGUI>().text = genInput;
        }
        else if (activeInput == Input2_1)
        {
            genInput = Input2_1.GetComponentInChildren<TextMeshProUGUI>().text;
            genInput = genInput.Remove(genInput.Length - 1);
            Input2_1.GetComponentInChildren<TextMeshProUGUI>().text = genInput;
        }
        else if (activeInput == Input2_2) //if (E3.activeSelf == true || E4.activeSelf == false)
        {
            genInput = Input2_2.GetComponentInChildren<TextMeshProUGUI>().text;
            genInput = genInput.Remove(genInput.Length - 1);
            Input2_2.GetComponentInChildren<TextMeshProUGUI>().text = genInput;
        }
    }
}
