using UnityEngine;
using UnityEngine.UI;

public class Methane : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] private Animator myAnimationControl;

    public GameObject egg, eggCenter, Db, vimSim, e6_anim1, e6_anim2, e6_anim3, e6_anim4, e6_anim5; // e4_anim6;
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

    public void Start()
    {
        //eggCenter.SetActive(false);
    }

    public void TrigUpdate()
    {
        LoadSprite();
        eggCenter.SetActive(false);
        egg.SetActive(true);
        Debug.Log(convoLine);


        if (convoLine == 0)
        {
            e6_anim1.SetActive(true);
            ChangeSprite(6);
        }
        else if (convoLine == 1)
        {
            e6_anim1.SetActive(false);
            e6_anim2.SetActive(true);
            ChangeSprite(2);
        }
        else if (convoLine == 2)
        {
            e6_anim2.SetActive(false);
            e6_anim3.SetActive(true);
            ChangeSprite(2);
        }
        else if (convoLine == 3)
        {
            e6_anim3.SetActive(false);
            e6_anim4.SetActive(true);
            ChangeSprite(2);
        }
        else if (convoLine == 4 || convoLine == 5 || convoLine == 6)
        {
            e6_anim4.SetActive(false);
            e6_anim5.SetActive(true);
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
        Sp_caterpillar = Resources.LoadAll<Sprite>("sp_caterpillar");

    }

    public void ChangeSprite(int index)
    {
        for (int i = 0; i < Sp_caterpillar.Length; i++)
        {
            if (i == index)
            {
                //E1.GetComponent<SpriteRenderer>().sprite = sprites[i];
                egg.GetComponent<Image>().sprite = Sp_caterpillar[i];
            };
        }
    }

    public void HideAll()
    {
        egg.SetActive(false);
        e6_anim1.SetActive(false);
        e6_anim2.SetActive(false);
        e6_anim3.SetActive(false);
        e6_anim4.SetActive(false);
        e6_anim5.SetActive(false);
        Db.SetActive(false);
    }
}
