using UnityEngine;
using UnityEngine.UI;

public class SilverPot : MonoBehaviour
{

    public GameObject egg, eggCenter, Db, vimSim, e7_anim1, e7_anim2, e7_anim3, e7_anim4, e7_anim5; // e4_anim6;
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
        eggCenter.SetActive(false);
        egg.SetActive(true);
        Debug.Log(convoLine);


        if (convoLine == 0)
        {
            e7_anim5.SetActive(true);
            ChangeSprite(6);
        }
        else if (convoLine == 1)
        {
            e7_anim5.SetActive(true);
            ChangeSprite(6);
            AudioManager.Instance.PlaySFX("Sparkle", false, 1f);
        }
        else if (convoLine == 2)
        {
            e7_anim5.SetActive(false);
            e7_anim1.SetActive(true);
            ChangeSprite(2);
        }
        else if (convoLine == 3)
        {
            e7_anim1.SetActive(false);
            e7_anim2.SetActive(true);
            ChangeSprite(1);
        }
        else if (convoLine == 4)
        {
            e7_anim2.SetActive(false);
            e7_anim3.SetActive(true);
            ChangeSprite(2);
            AudioManager.Instance.PlaySFX("Blink", false, 0.5f);
        }
        else if (convoLine == 5)
        {
            e7_anim2.SetActive(false);
            e7_anim3.SetActive(true);
            ChangeSprite(2);
            AudioManager.Instance.PlaySFX("Blink");
        }
        else if (convoLine == 6)
        {
            e7_anim3.SetActive(false);
            e7_anim4.SetActive(true);
            ChangeSprite(0);
        }
        else if (convoLine == 7)
        {
            e7_anim3.SetActive(false);
            e7_anim4.SetActive(true);
            ChangeSprite(0);
            AudioManager.Instance.PlaySFX("Yay", false, 1f);
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
        e7_anim1.SetActive(false);
        e7_anim2.SetActive(false);
        e7_anim3.SetActive(false);
        e7_anim4.SetActive(false);
        e7_anim5.SetActive(false);
        Db.SetActive(false);
    }
}
