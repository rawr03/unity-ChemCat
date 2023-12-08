using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Synthesis : MonoBehaviour
{
    public GameObject egg, Db, Ex_anim1, Ex_anim2, Ex_anim3, Ex_anim4, Ex_anim5, Ex_anim6, Ex_anim7, Ex_anim8, Ex_anim9, Ex_anim10, Ex_anim11;
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


        if (convoLine == 0)
        {
            ChangeSprite(1);
        }
        else if (convoLine == 1)
        {
            ChangeSprite(0);
        }
        else if (convoLine == 2)
        {
            ChangeSprite(6);
        }
        else if (convoLine == 3)
        {
            Ex_anim1.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Sparkle", false, 1.5f);
        }
        else if (convoLine == 4)
        {
            Ex_anim1.SetActive(false);
            Ex_anim2.SetActive(true);
            ChangeSprite(1);
        }
        else if (convoLine == 5)
        {
            Ex_anim2.SetActive(false);
            Ex_anim3.SetActive(true);
            ChangeSprite(6);
        }
        else if (convoLine == 6)
        {
            Ex_anim3.SetActive(false);
            Ex_anim4.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Blink", false, 0.5f);
        }
        else if (convoLine == 7)
        {
            Ex_anim4.SetActive(false);
            Ex_anim5.SetActive(true);
            ChangeSprite(1);
            //AudioManager.Instance.PlaySFX("Blink");
        }
        else if (convoLine == 8 || convoLine == 9)
        {
            Ex_anim5.SetActive(false);
            Ex_anim6.SetActive(true);
            ChangeSprite(0);
        }
        else if (convoLine == 10)
        {
            Ex_anim6.SetActive(false);
            Ex_anim7.SetActive(true);
            ChangeSprite(1);
            //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 11)
        {
            Ex_anim7.SetActive(false);
            Ex_anim8.SetActive(true);
            ChangeSprite(6);
            //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 12 || convoLine == 13)
        {
           Ex_anim8.SetActive(false);
           Ex_anim9.SetActive(true);
           ChangeSprite(6);
           //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 14)
        {
           Ex_anim9.SetActive(false);
           Ex_anim10.SetActive(true);
           ChangeSprite(1);
           //AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 15 || convoLine == 16 || convoLine == 17)
        {
            Ex_anim10.SetActive(false);
            Ex_anim11.SetActive(true);
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
        Ex_anim1.SetActive(false);
        Ex_anim2.SetActive(false);
        Ex_anim3.SetActive(false);
        Ex_anim4.SetActive(false);
        Ex_anim5.SetActive(false);
        Ex_anim6.SetActive(false);
        Ex_anim7.SetActive(false);
        Ex_anim8.SetActive(false);
        Ex_anim9.SetActive(false);
        Ex_anim10.SetActive(false);
        Ex_anim11.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
