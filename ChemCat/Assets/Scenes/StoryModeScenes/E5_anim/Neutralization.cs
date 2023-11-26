using UnityEngine;
using UnityEngine.UI;

public class Neutralization : MonoBehaviour
{
    [SerializeField] private Animator myAnimationControl;

    public GameObject egg, eggCenter, Db, vimSim, e5_anim1, e5_anim2, e5_anim3, e5_anim4, e5_anim5; // e4_anim6;
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
        myAnimationControl.Play("Checkpoint_Anim");
    }

    public void TrigUpdate()
    {
        LoadSprite();
        eggCenter.SetActive(false);
        egg.SetActive(true);
        Debug.Log(convoLine);


        if (convoLine == 0 || convoLine == 1)
        {
            e5_anim1.SetActive(true);
            ChangeSprite(6);
        }
        else if (convoLine == 2)
        {
            e5_anim1.SetActive(false);
            e5_anim2.SetActive(true);
            ChangeSprite(2);
        }
        else if (convoLine == 3)
        {
            e5_anim2.SetActive(false);
            e5_anim3.SetActive(true);
            ChangeSprite(2);
        }
        else if (convoLine == 4 || convoLine == 5)
        {
            e5_anim3.SetActive(false);
            e5_anim4.SetActive(true);
            ChangeSprite(6);
        } 
        else if (convoLine == 6 || convoLine == 7 || convoLine == 8 || convoLine == 9 || convoLine == 10)
        {
            e5_anim4.SetActive(false);
            e5_anim5.SetActive(true);
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
                egg.GetComponent<Image>().sprite = Sp_caterpillar[i];
            };
        }
    }

    public void HideAll()
    {
       
        egg.SetActive(false);
        e5_anim1.SetActive(false);
        e5_anim2.SetActive(false);
        e5_anim3.SetActive(false);
        e5_anim4.SetActive(false);
        e5_anim5.SetActive(false);
        Db.SetActive(false);
    }
}
