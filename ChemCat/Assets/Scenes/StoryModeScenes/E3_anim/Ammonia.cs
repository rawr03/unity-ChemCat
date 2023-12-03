using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Linq;
using System;

public class Ammonia : MonoBehaviour
{
    [SerializeField] private Animator myAnimationControl;

    public GameObject egg, Db, vimSim, e3_anim1, e3_anim2, e3_anim3, e3_anim4, e3_anim5;
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

    }

    public void TrigUpdate()
    {

        //egg.GetComponent<Image>().sprite = Resources.LoadAll("sp_egg", typeof(Sprite));
        //equationText_anim.enabled = false;

        LoadSprite();
        egg.SetActive(true);

        Debug.Log(convoLine);
        if (convoLine == 0)
        {
            e3_anim1.SetActive(true);
            ChangeSprite(6);
            AudioManager.Instance.PlaySFX("Sniff", false, 0.25f);
        }
        else if (convoLine == 1 || convoLine == 2)
        {
            e3_anim1.SetActive(false);
            e3_anim2.SetActive(true);
            ChangeSprite(2);
        }
        else if (convoLine == 3)
        {
            e3_anim1.SetActive(false);
            e3_anim2.SetActive(true);
            ChangeSprite(2);
            AudioManager.Instance.PlaySFX("ToiletFlush");
        }
        else if (convoLine == 4)
        {
            e3_anim2.SetActive(false);
            e3_anim3.SetActive(true);
            ChangeSprite(1);
            AudioManager.Instance.PlaySFX("Correct", false, 0.5f);
        }
        else if (convoLine == 5)
        {
            e3_anim3.SetActive(false);
            e3_anim4.SetActive(true);
            ChangeSprite(1);
            AudioManager.Instance.PlaySFX("Yay", false, 0.5f);
        }
        else if (convoLine == 6)
        {
            e3_anim4.SetActive(false);
            e3_anim5.SetActive(true);
            ChangeSprite(6);
        }
        else if (convoLine == 7)
        {
            e3_anim5.SetActive(false);
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
        //egg.SetActive(false);
        e3_anim1.SetActive(false);
        e3_anim2.SetActive(false);
        e3_anim3.SetActive(false);
        e3_anim4.SetActive(false);
        e3_anim5.SetActive(false);
        Db.SetActive(false);
    }
}
