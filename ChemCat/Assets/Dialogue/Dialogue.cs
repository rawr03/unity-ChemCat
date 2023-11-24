using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.SceneManagement;
using UnityEngine;


[System.Serializable]
public class Dialogue
{
    public string problem;
    public string[] sentences;
}


public enum Expression
{
    smile,
    openmouthsmile,
    closedsmile,
    angry,  
    sad,
    scared,
    smart,
    cat,
    meh
}


[System.Serializable]
public class DialogueInfoList
{
    public List<DialogueArray> list = new List<DialogueArray> ();
}


[System.Serializable]
public class DialogueArray
{
    public string propName;
    //public Expression expression;
}