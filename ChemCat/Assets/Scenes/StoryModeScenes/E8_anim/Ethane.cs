using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ethane : MonoBehaviour
{
    [SerializeField] private Animator myAnimationControl;

    public GameObject pupa, db_pupa, Db, db_anim, vimSim, e8_anim1, e8_anim2, e8_anim3, e8_anim4, e8_anim5;
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
        myAnimationControl.Play("Checkpoint_Anim");
    }

    public void TrigUpdate()
    {
        pupa.SetActive(false);
        
        LoadSprite();
        Debug.Log(convoLine);
        if (convoLine == 0)
        {
            db_pupa.SetActive(true);
            e8_anim1.SetActive(true);
            AudioManager.Instance.PlaySFX("Campfire");
        }
        else if (convoLine == 1)
        {
            db_pupa.SetActive(false);
            db_anim.SetActive(true);
            e8_anim1.SetActive(false);
            e8_anim2.SetActive(true);
            ChangeSprite(2);
        }
        else if (convoLine == 2)
        {
            e8_anim2.SetActive(false);
            e8_anim3.SetActive(true);
            ChangeSprite(1);
            AudioManager.Instance.PlaySFX("Wow", false, 1.5f);
        }
        else if (convoLine == 3)
        {
            e8_anim3.SetActive(false);
            e8_anim4.SetActive(true);
            ChangeSprite(1);
        }
        else if (convoLine == 4)
        {
            e8_anim4.SetActive(false);
            e8_anim5.SetActive(true);
            ChangeSprite(6);
        }
        else if (convoLine == 5)
        {
            e8_anim5.SetActive(false);
            ChangeSprite(6);
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
                //egg.GetComponent<Image>().sprite = Sp_eggs[i];
            };
        }
    }

    public void HideAll()
    {
        e8_anim1.SetActive(false);
        e8_anim2.SetActive(false);
        e8_anim3.SetActive(false);
        e8_anim4.SetActive(false);
        e8_anim5.SetActive(false);
        Db.SetActive(false);
        db_anim.SetActive(false);
    }
}
