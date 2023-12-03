using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Windows;

public class Subscript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sb, Input;
    string genInput;
    string InputEq = null;

    BuildEq bEq;

    public void InputSub()
    {
        bEq = FindObjectOfType<BuildEq>();
        genInput = sb.GetComponentInChildren<TextMeshProUGUI>().text;
        //InputEq = InputEq + genInput;
        bEq.UpdateInput(genInput);
        //Input.GetComponentInChildren<TextMeshProUGUI>().text = InputEq;
        //EqBuild[inputIndex] = genInput;
        //inputIndex++;
    }

    public void BackSpace()
    {
        bEq = FindObjectOfType<BuildEq>();
        genInput = Input.GetComponentInChildren<TextMeshProUGUI>().text;
        genInput = genInput.Remove(genInput.Length-1);
        Input.GetComponentInChildren<TextMeshProUGUI>().text = genInput;
    }
}
