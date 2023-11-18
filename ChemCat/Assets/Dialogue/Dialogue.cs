using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string problem;
    [TextArea(3, 15)]

    public string[] sentences;
    public Expression expression;
    /*
    public Sprite smile;
    public Sprite openmouthsmile;
    public Sprite angry;
    public Sprite sad;
    public Sprite scared;
    public Sprite smart;
    public Sprite cat;
    public Sprite meh; 
    */

}
