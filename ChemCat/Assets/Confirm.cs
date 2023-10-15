using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confirm : MonoBehaviour
{
    // Start is called before the first frame update

    public static int health; 
    public static int element1 = 1; //coefficient 1
    public static int element2 = 1; //coefficient 2
    public static int element3 = 1; //coefficient 3
    public static int element4 = 1; //coefficient 4

    public static int subscript1 = 0; //subscript 1
    public static int subscript2 = 0; //subscript 1
    public static int subscript3 = 0; //subscript 1
    public static int subscript4 = 0; //subscript 1

    public static int input1 = 1;
    public static int input2 = 1;
    public static int input3 = 1;
    public static int input4 = 1;

    public static int leftAnswer; // multiply coefficient and subscript [Correct Answer]
    public static int rightAnswer; // multiply coefficient and subscript [Correct Answer]
    public static int leftProduct; // multiply coefficient and subscript [Player Input]
    public static int rightProduct; // multiply coefficient and subscript [Player Input]

    public static int confirmInput = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* reference health-- if player input is wrong
        leftProduct = input1 * subscript1;
        rightProduct = input3 * subscript3;
        switch (confirmInput)
        {

        }
        */
    }
}
