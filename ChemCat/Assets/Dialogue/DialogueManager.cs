using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using TMPro;
using Unity.Burst.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
//using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.U2D;
using UnityEngine.UIElements;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText, skip;
    private Queue<string> sentences;
    public float DialogueSpeed;

    public int attempt;
    //public Sprite[] sprites;
    public Sprite[] expressions;
    //private Sprite sprite;
    public int dialogueIndex = 0;

    // Sprite
    public GameObject currentFace, egg;
    private string propName;
    public GameObject prop;
    public int index;

    public GameObject db, vimSim;
    public DialogueArray dialogueArray;
    //public GameObject db, vimSim;
    //public DialogueArray dialogueArray;
    //public DialogueArray dialogueArray;



    // Start is called before the first frame updateGFF
    void Start()
    {
        //eq.enabled = false; 
        vimSim.gameObject.SetActive(false);
        prop.gameObject.SetActive(false);
      
        vimSim.SetActive(false);
        prop.SetActive(false);
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
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

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";

        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(DialogueSpeed);
        }
    }

    void EndDialogue()
    {
        Debug.Log("End");
        egg.SetActive(false);
        //prop.SetActive(false);
        prop.SetActive(false);
        StartPlay();

    }

    public void SetupSprites()
    {
        expressions = Resources.LoadAll("storymode", typeof(Sprite)).Cast<Sprite>().ToArray();

        for (int i = 0; i < expressions.Length; i++)
        {
            if (expressions[i].name == propName)
            {
                prop.GetComponent<UnityEngine.UI.Image>().sprite = expressions[i];
            }
        }
        //E.GetComponent<UnityEngine.UI.Image>().sprite = sprites[i];
    }

    /*
    public void GetDialogueInfo(DialogueArray dialogueArray)
    {   if (currentLine == dialogue.sentence[i])
        if(currentIndex == string.Empty)
        {
            propName = dialogueArray.propName;
            index = (int)expressions.GetValue(index);
            SetupSprites();
            ChangeFace(index);
        }
        propName = dialogueArray.propName;
        SetupSprites();
        prop.SetActive(true);
    }*/

    public void ChangeFace(int index)
    {
        for (int i = 0; i < expressions.Length; i++)
        {
            if (i == index)
            {
                currentFace.GetComponent<Image>().sprite = expressions[i];
            };
        }
    }

    public void StartPlay()
    {
        //egg.SetActive(false);
        db.SetActive(false);
        vimSim.SetActive(true);
    }

    public void Skip()
    {
        //egg.SetActive(false);
        EndDialogue();
    }

}