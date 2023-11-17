using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using Unity.VisualScripting;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine.SceneManagement;
using TMPro;

public class VisualsControl : MonoBehaviour
{
    public GameObject E1, E2, E3, E4, E5, E6, E7, E8, E9;
    public GameObject inputNum;

    private static string Num;


    public void Visuals()
    {
        Num = inputNum.GetComponent<Text>().text;
        Num.Trim();

        switch (Num)
        {
           /*
            case "0":
                E1.gameObject.SetActive(false);
                E2.gameObject.SetActive(false);
                E3.gameObject.SetActive(false);
                E4.gameObject.SetActive(false);
                E5.gameObject.SetActive(false);
                E6.gameObject.SetActive(false);
                E7.gameObject.SetActive(false);
                E8.gameObject.SetActive(false);
                E9.gameObject.SetActive(false);
           */
            case "1":
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


            case "2":
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

            case "3":
                E1.gameObject.SetActive(true);
                E2.gameObject.SetActive(true);
                E3.gameObject.SetActive(true);
                E4.gameObject.SetActive(false);
                E5.gameObject.SetActive(false);
                E6.gameObject.SetActive(false);
                E7.gameObject.SetActive(false);
                E8.gameObject.SetActive(false);
                E9.gameObject.SetActive(false);
                break;

            case "4":
                E1.gameObject.SetActive(true);
                E2.gameObject.SetActive(true);
                E3.gameObject.SetActive(true);
                E4.gameObject.SetActive(true);
                E5.gameObject.SetActive(false);
                E6.gameObject.SetActive(false);
                E7.gameObject.SetActive(false);
                E8.gameObject.SetActive(false);
                E9.gameObject.SetActive(false);
                break;

            case "5":
                E1.gameObject.SetActive(true);
                E2.gameObject.SetActive(true);
                E3.gameObject.SetActive(true);
                E4.gameObject.SetActive(true);
                E5.gameObject.SetActive(true);
                E6.gameObject.SetActive(false);
                E7.gameObject.SetActive(false);
                E8.gameObject.SetActive(false);
                E9.gameObject.SetActive(false);
                break;

            case "6":
                E1.gameObject.SetActive(true);
                E2.gameObject.SetActive(true);
                E3.gameObject.SetActive(true);
                E4.gameObject.SetActive(true);
                E5.gameObject.SetActive(true);
                E6.gameObject.SetActive(true);
                E7.gameObject.SetActive(false);
                E8.gameObject.SetActive(false);
                E9.gameObject.SetActive(false);
                break;

            case "7":
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

            case "8":
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

            case "9":
                E1.gameObject.SetActive(true);
                E2.gameObject.SetActive(true);
                E3.gameObject.SetActive(true);
                E4.gameObject.SetActive(true);
                E5.gameObject.SetActive(true);
                E6.gameObject.SetActive(true);
                E7.gameObject.SetActive(true);
                E8.gameObject.SetActive(true);
                E9.gameObject.SetActive(true);
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
        Visuals();
    }
}
