using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Linq;

public class Water : MonoBehaviour
{                           
    [SerializeField] private Animator myAnimationControl;

    public GameObject egg, prop, molecule, line1, line2, eq_Text, subscripts, eq_H2O;
    private int convoLine = -1;
    //public TextMeshProUGUI equationText_anim;

    public Sprite[] Sp_eggs;

    public void Start()
    {
        eq_Text.SetActive(false);
    }

    public void TrigUpdate()
    {
        //egg.GetComponent<Image>().sprite = Resources.LoadAll("sp_egg", typeof(Sprite));
        //equationText_anim.enabled = false;
        Debug.Log(convoLine);
        if(convoLine == 0)
        {
            myAnimationControl.Play("e1_show");
        }
        else if (convoLine == 1)
        {
            molecule.SetActive(true);
            myAnimationControl.Play("e1_moveleft");
            myAnimationControl.Play("e1_Mole");
        }
        else if (convoLine == 2)
        {
            eq_Text.SetActive(true);
            prop.transform.localScale = new Vector3(0, 0, 0);
            molecule.SetActive(false);
            myAnimationControl.Play("e1_eq");
        }
        else if (convoLine == 3)
        {
            line1.SetActive(true);
            myAnimationControl.Play("e1_eq1");
            line2.SetActive(true);
            myAnimationControl.Play("e1_eq2");
            
        }
        else if (convoLine == 4)
        {
            line1.SetActive(false);
            line2.SetActive(false);
            subscripts.SetActive(true);
        }
        else if (convoLine == 5)
        {
            subscripts.SetActive(false);
            eq_Text.SetActive(false);
        }
        else if (convoLine == 6)
        {
            eq_H2O.SetActive(true);
        }
        else if (convoLine == 7)
        {
            eq_H2O.SetActive(false);
        }
        Next();
    }

    /*
    IEnumerator Delay()
    {
        StartCoroutine(Delay());
        yield return new WaitForSeconds(4f);
    }
    */

    public void Next()
    {
        convoLine++;
    }
}
