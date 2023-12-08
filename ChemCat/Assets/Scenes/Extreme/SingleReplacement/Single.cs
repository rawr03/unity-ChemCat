using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Single : MonoBehaviour
{
    public GameObject egg, Db, SR_anim2, SR_anim3, SR_anim4, SR_anim5, SR_anim6, SR_anim7, SR_anim8, SR_anim9, SR_anim10, SR_anim11, SR_anim12, SR_anim13, SR_anim14, SR_anim15, SR_anim16, SR_anim17;
    private int convoLine = 0;
    public int index = 0;
    public Sprite[] Sp_caterpillar;

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

    public void TrigUpdate()
    {
        LoadSprite();
        //eggCenter.SetActive(false);
        egg.SetActive(true);
        Debug.Log(convoLine);


        if (convoLine == 0 || convoLine == 1)
        {
            ChangeSprite(1);
        }
        else if (convoLine == 2)
        {
            SR_anim2.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Sparkle", false, 1.5f);
        }
        else if (convoLine == 3)
        {
            SR_anim2.SetActive(false);
            SR_anim3.SetActive(true);
            ChangeSprite(1);
        }
        else if (convoLine == 4)
        {
            SR_anim3.SetActive(false);
            SR_anim4.SetActive(true);
            ChangeSprite(6);
        }
        else if (convoLine == 5)
        {
            SR_anim4.SetActive(false);
            SR_anim5.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Blink", false, 0.5f);
        }
        else if (convoLine == 6)
        {
            SR_anim5.SetActive(false);
            SR_anim6.SetActive(true);
            ChangeSprite(1);
            //AudioManager.Instance.PlaySFX("Blink");
        }
        else if (convoLine == 7)
        {
            SR_anim6.SetActive(false);
            SR_anim7.SetActive(true);
            ChangeSprite(0);
        }
        else if (convoLine == 8)
        {
            SR_anim7.SetActive(false);
            SR_anim8.SetActive(true);
            ChangeSprite(1);
            //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 9)
        {
            SR_anim8.SetActive(false);
            SR_anim9.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 10)
        {
            SR_anim9.SetActive(false);
            SR_anim10.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 11)
        {
            SR_anim10.SetActive(false);
            SR_anim11.SetActive(true);
            ChangeSprite(1);
            //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 12)
        {
            SR_anim11.SetActive(false);
            SR_anim12.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 13)
        {
            SR_anim12.SetActive(false);
            SR_anim13.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 14)
        {
            SR_anim13.SetActive(false);
            SR_anim14.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 15)
        {
            SR_anim14.SetActive(false);
            SR_anim15.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 16)
        {
            SR_anim15.SetActive(false);
            SR_anim16.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 17)
        {
            SR_anim16.SetActive(false);
            SR_anim17.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Yay", false, 1f);
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
        Sp_caterpillar = Resources.LoadAll<Sprite>("sp_caterpillar");

    }

    public void ChangeSprite(int index)
    {
        for (int i = 0; i < Sp_caterpillar.Length; i++)
        {
            if (i == index)
            {
                egg.GetComponent<Image>().sprite = Sp_caterpillar[i];
            };
        }
    }

    public void HideAll()
    {
        egg.SetActive(false);
        SR_anim2.SetActive(false);
        SR_anim3.SetActive(false);
        SR_anim4.SetActive(false);
        SR_anim5.SetActive(false);
        SR_anim6.SetActive(false);
        SR_anim7.SetActive(false);
        SR_anim8.SetActive(false);
        SR_anim9.SetActive(false);
        SR_anim10.SetActive(false);
        SR_anim11.SetActive(false);
        SR_anim12.SetActive(false);
        SR_anim13.SetActive(false);
        SR_anim14.SetActive(false);
        SR_anim15.SetActive(false);
        SR_anim16.SetActive(false);
        SR_anim17.SetActive(false);
        Db.SetActive(false);
    }
}