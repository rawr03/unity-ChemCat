using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayFunctionalities : MonoBehaviour
{
    
    public Text CurrentNum;
    public int number = 0;
    public GameObject plus;
    public GameObject minus;

    public void Add()
    {
        number++;
        CurrentNum.text = number.ToString();
    }

    public void Subract()
    {
        number--;
        CurrentNum.text = number.ToString();
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
