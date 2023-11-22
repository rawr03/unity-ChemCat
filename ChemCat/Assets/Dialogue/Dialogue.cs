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

/*
[System.Serializable]
public class DialogueArray
{
    public string dialogueLine;
    public GameObject sprite;
    public GameObject image;
    public Expression expression;
    public string propName;
}
*/
/*
[System.Serializable]
public class Cell
{
    //some stuff
}

[System.Serializable]
public class Array
{
    public List<Cell> cells = new List<Cell>();
    public Cell this[int index] => cells[index];
}

[System.Serializable]
public class Matrix
{
    public List<Array> arrays = new List<Array>();
    public Cell this[int x, int y] => arrays[x][y];
}
 * */


[System.Serializable]
public class DialogueInfoList
{
    public List<DialogueArray> list = new List<DialogueArray> ();
}

[System.Serializable]
public class DialogueArray
{
    public string propName;
    public Expression expression;
}



/*
[System.Serializable]
public class Matrix
{
    public List<Dialogue[]> arrays = new List<Dialogue[]>();
    public Dialogue this[int x, int y] => arrays[x][y];
}

/*
[System.Serializable]
public class Matrix
{
    public List<Dialogue[]> problemsList = new List<Dialogue[]>();
    public Dialogue this[int x, int y] => problemsList[x][y];

    //public List<string[]> alphabet = new List<string[]>();
}
/*
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * public class MySample : MonoBehaviour, ISerializationCallbackReceiver
{
    public Vector3[,] unserializable = new Vector3[3, 3];
 
    // A list that can be serialized
    [SerializeField, HideInInspector] private List<Package<Vector3>> serializable;
    // A package to store our stuff
    [System.Serializable]
    struct Package<TElement>
    {
        public int Index0;
        public int Index1;
        public TElement Element;
        public Package(int idx0, int idx1, TElement element)
        {
            Index0 = idx0;
            Index1 = idx1;
            Element = element;
        }
    }
    public void OnBeforeSerialize()
    {
        // Convert our unserializable array into a serializable list
        serializable = new List<Package<Vector3>>();
        for (int i = 0; i < unserializable.GetLength(0); i++)
        {
            for (int j = 0; j < unserializable.GetLength(1); j++)
            {
                serializable.Add(new Package<Vector3>(i, j, unserializable[i, j]));
            }
        }
    }
    public void OnAfterDeserialize()
    {
        // Convert the serializable list into our unserializable array
        unserializable = new Vector3[3, 3];
        foreach(var package in serializable)
        {
            unserializable[package.Index0, package.Index1] = package.Element;
        }
    }
}*/