using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System.Linq;
<<<<<<< Updated upstream:ChemCat/Assets/Scenes/StoryModeScenes/stry_anim/Water.cs
=======
using System;
>>>>>>> Stashed changes:ChemCat/Assets/Scenes/StoryModeScenes/E4_anim/Ethanol.cs

public class Water : MonoBehaviour
{
    [SerializeField] private Animator myAnimationControl;

    public GameObject egg, Db, vimSim, e4_anim1, e4_anim2, e4_anim3, e4_anim4, e4_anim5, e4_anim6;
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
<<<<<<< Updated upstream:ChemCat/Assets/Scenes/StoryModeScenes/stry_anim/Water.cs
        //egg.GetComponent<Image>().sprite = Resources.LoadAll("sp_egg", typeof(Sprite));
        //equationText_anim.enabled = false;
=======
        LoadSprite();
        egg.SetActive(true);
>>>>>>> Stashed changes:ChemCat/Assets/Scenes/StoryModeScenes/E4_anim/Ethanol.cs
        Debug.Log(convoLine);
        if (convoLine == 0)
        {
            e4_anim1.SetActive(true);
            ChangeSprite(6);
        }
        else if (convoLine == 1)
        {
            e4_anim1.SetActive(false);
            e4_anim2.SetActive(true);
            ChangeSprite(2);
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
        else
        {
<<<<<<< Updated upstream:ChemCat/Assets/Scenes/StoryModeScenes/stry_anim/Water.cs
            eq_H2O.SetActive(false);
            eq_2.SetActive(true);
        }
        else if (convoLine == 8)
        {
            eq_2.SetActive(false);
            distribCoef.SetActive(true);
        }
        else if (convoLine == 9 || convoLine == 10 || convoLine == 11)
        {
            distribCoef.SetActive(false);
            listeq.SetActive(true);
        }
        else if (convoLine == 12)
        {
            listeq.SetActive(false);
            viseq.SetActive(true);
        }
        else if (convoLine == 13)
        {
            viseq.SetActive(false);
            vimSim.SetActive(true);
        }
        else if (convoLine == 14)
        {
            //vimSim.SetActive(false);
            
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
        }
        else if (convoLine == 18)
        {
            black.SetActive(false);
            hearts.SetActive(false);
            gameplay.SetActive(true);
            //confirm.SetActive(true);
=======
            HideAll();
>>>>>>> Stashed changes:ChemCat/Assets/Scenes/StoryModeScenes/E4_anim/Ethanol.cs
        }

        Next();
    }

    /*
    IEnumerator Delay()
    {
        StartCoroutine(Delay());
        yield return new WaitForSeconds(4f);
    }
    */
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
<<<<<<< Updated upstream:ChemCat/Assets/Scenes/StoryModeScenes/stry_anim/Water.cs
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
=======
        egg.SetActive(false);
        Db.SetActive(false);
        e4_anim1.SetActive(false); 
        e4_anim2.SetActive(false); 
        e4_anim3.SetActive(false); 
        e4_anim4.SetActive(false); 
        e4_anim5.SetActive(false); 
        e4_anim6.SetActive(false);
        //vimSim.SetActive(true);
>>>>>>> Stashed changes:ChemCat/Assets/Scenes/StoryModeScenes/E4_anim/Ethanol.cs
    }
}
