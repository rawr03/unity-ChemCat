using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Linq;
using System;

public class Water : MonoBehaviour
{
    [SerializeField] private Animator myAnimationControl;

    public GameObject egg, egg_center, prop, molecule, line1, line2, eq_Text, subscripts, eq_H2O, eq_2, distribCoef, listeq, vimSim, viseq, confirm, gameplay, hearts, black, startPlay, visSimAnim;
    private int convoLine = 0;
    //public TextMeshProUGUI equationText_anim;
    public int index = 0;
    public Sprite[] Sp_eggs;
    //public string[] Sp_faces;

    /*
    public string Stage;
    //public Sprite portrait;
    //public Sprite portraitAngry;
    


    ChemCat Face List:

    smile(0);
    openmouthsmile(1);
    closedsmile(2);
    angry(3);
    sad(4);
    scared(5);
    smart(6);
    cat(7);
    meh(8);
    */



    public void Start()
    {
        myAnimationControl.Play("egg_SP");
        //egg.SetActive(true);
        egg_center.SetActive(false);
        //convoLine = 0;
        //eq_Text.SetActive(false);
    }

    public void TrigUpdate()
    {
        LoadSprite();
        egg.SetActive(true);
        Debug.Log(convoLine);
        if (convoLine == 0)
        {
            prop.SetActive(true);
            myAnimationControl.Play("e1_show");
            ChangeSprite(6);
            AudioManager.Instance.PlaySFX("E1_WaterDrop");
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
            ChangeSprite(1);
        }
        else if (convoLine == 3)
        {
            line1.SetActive(true);
            myAnimationControl.Play("e1_eq1");
            line2.SetActive(true);
            myAnimationControl.Play("e1_eq2");
            ChangeSprite(2);
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
            ChangeSprite(6);
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
        else if (convoLine == 9)
        {
            ChangeSprite(2);
            distribCoef.SetActive(false);
            listeq.SetActive(true);
        }
        else if (convoLine == 10 || convoLine == 11)
        {
            ChangeSprite(1);
        }
        else if (convoLine == 12)
        {
            listeq.SetActive(false);
            viseq.SetActive(true);
            ChangeSprite(2);
        }
        else if (convoLine == 13 || convoLine == 14)
        {
            viseq.SetActive(false);
            vimSim.SetActive(true);
            ChangeSprite(0);
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
            ChangeSprite(5);
        }
        else if (convoLine == 17)
        {
            ChangeSprite(1);
        }
        else if (convoLine == 18)
        {
            black.SetActive(false);
            hearts.SetActive(false);
            visSimAnim.SetActive(true);
            ChangeSprite(2);
        }
        else if (convoLine == 19 || convoLine == 20 || convoLine == 21 || convoLine == 22)
        {
            visSimAnim.SetActive(false);
            gameplay.SetActive(true);
            ChangeSprite(6);
        }
        else
        {
            HideAll();
        }

        Next();
    }
    
    public void Next()
    {
        convoLine++;
    }

    public void LoadSprite()
    {
        Sp_eggs = Resources.LoadAll<Sprite>("sp_egg");

    }

    public void ChangeSprite(int index)
    {
        for (int i = 0; i < Sp_eggs.Length; i++)
        {
            if (i == index)
            {
                //E1.GetComponent<SpriteRenderer>().sprite = sprites[i];
                egg.GetComponent<Image>().sprite = Sp_eggs[i];
            };
        }
    }

    public void HideAll()
    {
        egg.SetActive(false);
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
        startPlay.SetActive(true);
    }
}
