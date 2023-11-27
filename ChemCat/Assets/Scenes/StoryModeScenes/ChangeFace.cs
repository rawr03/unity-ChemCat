using UnityEngine;
using UnityEngine.UI;

public class ChangeFace : MonoBehaviour
{
    private int convoLine = 0;
    public int index = 0;
    public Sprite[] Sp_eggs;
    public GameObject charCenter;

    // Start is called before the first frame update
    public void LoadSprite()
    {
        Sp_eggs = Resources.LoadAll<Sprite>("sp_egg");
    }

    public void Next()
    {
        convoLine++;
    }
    public void ChangeSprite(int index)
    {
        for (int i = 0; i < Sp_eggs.Length; i++)
        {
            if (i == index)
            {
                charCenter.GetComponent<Image>().sprite = Sp_eggs[i];
            };
        }
    }

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
        Debug.Log(convoLine);


        if (convoLine == 0)
        {
            ChangeSprite(0);
            AudioManager.Instance.PlaySFX("Sparkle", false);
        }
        else if (convoLine == 1)
        {
            ChangeSprite(2);
        }
        else if (convoLine == 2)
        {
            ChangeSprite(3);
            AudioManager.Instance.PlaySFX("AngryCat", false);
        }
        else if (convoLine == 3)
        {
            ChangeSprite(2);
        }
        else if (convoLine == 4)
        {
            ChangeSprite(7);
            AudioManager.Instance.PlaySFX("WahWahWah", false, 1f);
        }
        else if (convoLine == 5)
        {
            ChangeSprite(8);
        }
        else if (convoLine == 6)
        {
            ChangeSprite(1);
            AudioManager.Instance.PlaySFX("Sparkle", false, 1.5f);
        }
        else if (convoLine == 7)
        {
            ChangeSprite(1);
        }
        convoLine++;
    }
}