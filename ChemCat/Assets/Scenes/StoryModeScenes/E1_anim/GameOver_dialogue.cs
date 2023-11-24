using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
//using UnityEngine.UI;

public class GameOver_dialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogueText, skip;
    //private Queue<string> gmSentences;
    public float DialogueSpeed;

    public int dialogueIndex = 0;
    public int index;
    public GameObject egg, gameOverAnim, gameOverPanel;
    public Sprite[] faces;

    //public TextMeshProUGUI dialogueText, skip, eq;
    private Queue<string> sentences;
    //public float DialogueSpeed;

    public int attempt;
    //public Sprite[] sprites;
    //public Sprite[] expressions;
    //private Sprite sprite;
    //public int dialogueIndex = 0;

    // Sprite
    //public GameObject currentFace;
    //private string propName;
    //public GameObject prop;
    //public int index;

    //public GameObject db, visSim;


    // Start is called before the first frame updateGFF

    /*
    void Start()
    {
        gmSentences = new Queue<string>();
    }

    public void GStartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting dialogue for problem #" + dialogue.problem);
        gmSentences.Clear();

        foreach (string gSentence in dialogue.sentences)
        {
            gmSentences.Enqueue(gSentence);
            //Debug.Log(sentence);
        }
            DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        dialogueIndex++;
        if (gmSentences.Count == 0)
        {
            GEndDialogue();
            return;
        }
        string gSentence = gmSentences.Dequeue();
        Debug.Log(gSentence);
        StopAllCoroutines();
        StartCoroutine(TypeSentence(gSentence));
    }

    IEnumerator TypeSentence(string gSentence)
    {
        dialogueText.text = "";

        foreach (char letter in gSentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(DialogueSpeed);
        }
    }

    void GEndDialogue()
    {
        Debug.Log("End");
        gameOverAnim.SetActive(false);  

    }

    public void GSkip()
    {
        GEndDialogue();
    }
    */

    void Start()
    {
        //visSim.SetActive(false);
        //prop.SetActive(false);
        sentences = new Queue<string>();
    }

    public void GStartDialogue(Dialogue dialogue)
    {
        if (attempt == 0)
        {
            Debug.Log("Starting dialogue for problem #" + dialogue.problem);
            //dialogueArray = new DialogueArray();

            sentences.Clear();

            foreach (string sentence in dialogue.sentences)
            {
                sentences.Enqueue(sentence);
                //line = sentence;
                //DialogueArray = new DialogueArray();
                //GetDialogueInfo(dialogueArray);
            }
            attempt++;
            DisplayNextSentence();
        }
        else
        {
            DisplayNextSentence();
        }
    }

    public void DisplayNextSentence()
    {
        Anim();
        dialogueIndex++;
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    public void StartPlay()
    {
        //db.SetActive(false);
    }

    public void Skip()
    {
        gameOverAnim.SetActive(false);
        gameOverPanel.SetActive(true);
        EndDialogue();
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(DialogueSpeed);
        }
    }

    public void EndDialogue()
    {
        Debug.Log("End");
        StoryControl.health = 3;
        gameOverPanel.SetActive(true);
        gameOverAnim.SetActive(false);
        //StartPlay();

    }

    public void GChangeFace(int dialogueIndex)
    {
        if (StoryControl.Diff == "Easy")
        {
            faces = Resources.LoadAll<Sprite>("sp_egg");
            for (int i = 0; i < faces.Length; i++)
            {
                if (i == dialogueIndex)
                {
                    //E1.GetComponent<SpriteRenderer>().sprite = sprites[i];
                    egg.GetComponent<UnityEngine.UI.Image>().sprite = faces[i];
                }
            }
        }
        else if (StoryControl.Diff == "Medium")
        {
            faces = Resources.LoadAll<Sprite>("sp_caterpillar");
            for (int i = 0; i < faces.Length; i++)
            {
                if (i == dialogueIndex)
                {
                    //E1.GetComponent<SpriteRenderer>().sprite = sprites[i];
                    egg.GetComponent<UnityEngine.UI.Image>().sprite = faces[i];
                }
            }
        }
        else
        {
            faces = Resources.LoadAll<Sprite>("pupa");
            egg.GetComponent<UnityEngine.UI.Image>().sprite = faces[0];
        }


        faces = Resources.LoadAll<Sprite>("sp_egg");
        for (int i = 0; i < faces.Length; i++)
        {
            if (i == dialogueIndex)
            {
                //E1.GetComponent<SpriteRenderer>().sprite = sprites[i];
                egg.GetComponent<UnityEngine.UI.Image>().sprite = faces[i];
            };
        }
    }

    public void Anim()
    {
        if(dialogueIndex == 0 || dialogueIndex == 1 || dialogueIndex == 2 || dialogueIndex == 3 || 
           dialogueIndex == 4 || dialogueIndex == 5)
        {
            GChangeFace(4);
        }
        else if(dialogueIndex == 6)
        {
            GChangeFace(1);
        }
        else
        {
            GChangeFace(2);
        }
    }
}