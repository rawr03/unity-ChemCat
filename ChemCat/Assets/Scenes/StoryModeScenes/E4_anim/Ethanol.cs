using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Linq;
using System;

public class Ethanol : MonoBehaviour
{
    [SerializeField] private Animator myAnimationControl;

    public GameObject egg, Db, vimSim, e4_anim1, e4_anim2, e4_anim3, e4_anim4, e4_anim5, e4_anim6;
    private int convoLine = 0;
    public int index = 0;
    public Sprite[] Sp_eggs;

    /*
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
        
    }

    public void TrigUpdate()
    {

        LoadSprite();
        egg.SetActive(true);

        Debug.Log(convoLine);
        if (convoLine == 0)
        {
            e4_anim1.SetActive(true);
            ChangeSprite(6);
            AudioManager.Instance.PlaySFX("Slurp");
        }
        else if (convoLine == 1)
        {
            e4_anim1.SetActive(false);
            e4_anim2.SetActive(true);
            ChangeSprite(2);
            AudioManager.Instance.PlaySFX("Sparkle");
        }
        else if (convoLine == 2)
        {
            e4_anim2.SetActive(false);
            e4_anim3.SetActive(true);
            ChangeSprite(1);
        }
        else if (convoLine == 3)
        {
            e4_anim3.SetActive(false);
            e4_anim4.SetActive(true);
            ChangeSprite(1);
        }
        else if (convoLine == 4 || convoLine == 5)
        {
            e4_anim4.SetActive(false);
            e4_anim5.SetActive(true);
            ChangeSprite(6);
        }
        else if (convoLine == 6)
        {
            e4_anim5.SetActive(false);
            e4_anim6.SetActive(true);
            ChangeSprite(6);
        }
        else if (convoLine == 7)
        {
            e4_anim6.SetActive(false);
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
                egg.GetComponent<Image>().sprite = Sp_eggs[i];
            };
        }
    }

    public void HideAll()
    {
        //egg.SetActive(false);
        e4_anim1.SetActive(false);
        e4_anim2.SetActive(false); 
        e4_anim3.SetActive(false); 
        e4_anim4.SetActive(false); 
        e4_anim5.SetActive(false); 
        e4_anim6.SetActive(false);
        Db.SetActive(false);
    }
}
