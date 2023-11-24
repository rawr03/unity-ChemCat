using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ethanol : MonoBehaviour
{
    [SerializeField] private Animator myAnimationControl;

    public GameObject egg, prop, molecule, line1, line2, eq_Text, subscripts, eq_H2O, eq_2, distribCoef, listeq, vimSim, viseq, confirm, gameplay, hearts, black, startPlay, visSimAnim;
    private int convoLine = 0;
    //public TextMeshProUGUI equationText_anim;

    public Sprite[] Sp_eggs;

    /// <summary>
    /// DialogueManager dialogueManager;
    /// </summary>

    public void Start()
    {
        //convoLine = 0;
        eq_Text.SetActive(false);
    }

    public void TrigUpdate()
    {
        Debug.Log(convoLine);
        if (convoLine == 0)
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
        else if (convoLine == 5 || convoLine == 6)
        {
            subscripts.SetActive(false);
            eq_Text.SetActive(false);
            eq_H2O.SetActive(true);
        }
        else if (convoLine == 7)
        {
            eq_H2O.SetActive(false);
            eq_2.SetActive(true);
        }
        else if (convoLine == 8)
        {
            eq_2.SetActive(false);
            distribCoef.SetActive(true);
        }
        else if (convoLine == 9 || convoLine == 10 || convoLine == 11)
        {
            distribCoef.SetActive(false);
            listeq.SetActive(true);
        }
        else if (convoLine == 12)
        {
            listeq.SetActive(false);
            viseq.SetActive(true);
        }
        else if (convoLine == 13)
        {
            viseq.SetActive(false);
            vimSim.SetActive(true);
        }
        else if (convoLine == 15)
        {
            vimSim.SetActive(false);
            confirm.SetActive(true);
        }
        else if (convoLine == 16)
        {
            confirm.SetActive(false);
            hearts.SetActive(true);
        }
        else if (convoLine == 18)
        {
            black.SetActive(false);
            hearts.SetActive(false);
            visSimAnim.SetActive(true);
        }
        else if (convoLine == 19)
        {
            visSimAnim.SetActive(false);
            gameplay.SetActive(true);
        }

        Next();
    }

    public void Next()
    {
        convoLine++;
    }

    public void HideAll()
    {
        /*
        prop.SetActive(false);
        molecule.SetActive(false);
        line1.SetActive(false);
        line2.SetActive(false);
        eq_Text.SetActive(false);
        subscripts.SetActive(false);
        eq_H2O.SetActive(false);
        eq_2.SetActive(false);
        distribCoef.SetActive(false);
        listeq.SetActive(false);
        vimSim.SetActive(false);
        viseq.SetActive(false);
        confirm.SetActive(false);
        gameplay.SetActive(false);
        hearts.SetActive(false);
        black.SetActive(false);
        startPlay.SetActive(true);*/
    }
}
