using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchTest : MonoBehaviour
{

    public Text CurrentNum;
    public int number = 1;
    public GameObject plus;
    public GameObject minus;

    public GameObject E1, E2, E3, E4, E5, E6, E7, E8, E9;

    //public string Textnumber; 
    public void Add()
    {
        if (number < 9)
        {
            number++;
            CurrentNum.text = number.ToString();
            Visuals(number);
        }

    }

    public void Subract()
    {
        if (number > 1)
        {
            number--;
            CurrentNum.text = number.ToString();
        }
    }

    
    public void Visuals(int number)
    {
        number = number;
        switch (number)
        {
            
            case 1:
                E1.gameObject.SetActive(true);
                E2.gameObject.SetActive(false);
                E3.gameObject.SetActive(false);
                E4.gameObject.SetActive(false);
                E5.gameObject.SetActive(false);
                E6.gameObject.SetActive(false);
                E7.gameObject.SetActive(false);
                E8.gameObject.SetActive(false);
                E9.gameObject.SetActive(false);
                break;


            case 2:
                E1.gameObject.SetActive(true);
                E2.gameObject.SetActive(true);
                E3.gameObject.SetActive(false);
                E4.gameObject.SetActive(false);
                E5.gameObject.SetActive(false);
                E6.gameObject.SetActive(false);
                E7.gameObject.SetActive(false);
                E8.gameObject.SetActive(false);
                E9.gameObject.SetActive(false);
                break;

            case 8:
                E1.gameObject.SetActive(true);
                E2.gameObject.SetActive(true);
                E3.gameObject.SetActive(true);
                E4.gameObject.SetActive(true);
                E5.gameObject.SetActive(true);
                E6.gameObject.SetActive(true);
                E7.gameObject.SetActive(true);
                E8.gameObject.SetActive(true);
                E9.gameObject.SetActive(false);
                break;

            case 7:
                E1.gameObject.SetActive(true);
                E2.gameObject.SetActive(true);
                E3.gameObject.SetActive(true);
                E4.gameObject.SetActive(true);
                E5.gameObject.SetActive(true);
                E6.gameObject.SetActive(true);
                E7.gameObject.SetActive(true);
                E8.gameObject.SetActive(false);
                E9.gameObject.SetActive(false);
                break;
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
