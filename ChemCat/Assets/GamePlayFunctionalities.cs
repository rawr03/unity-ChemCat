using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayFunctionalities : MonoBehaviour
{
    
    public Text CurrentNum;
    public int number = 1;
    public GameObject plus;
    public GameObject minus;
    public string Textnumber; 
    public void Add()
    {
        if (number < 9)
        {   
            number++;
            CurrentNum.text = number.ToString();
            Textnumber = number.ToString();

        }
        
    }

    public void Subract()
    {
        if(number>1)
        {
            number--;
            CurrentNum.text = number.ToString();
            Textnumber = number.ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
}
}
