using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.U2D;
using UnityEngine.UIElements;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;
    public float DialogueSpeed;

    public int attempt;
    //public Sprite[] sprites;
    public Sprite[] expressions;
    //private Sprite sprite;
    public int dialogueIndex = 0;

    // Sprite
    public GameObject currentFace;
    private string propName;
    public GameObject prop;
    public int index;

    public GameObject db, visSim;
    public DialogueArray dialogueArray;

    //public Expression faces;

    // Start is called before the first frame update
    void Start()
    {
        visSim.gameObject.SetActive(false);
        prop.gameObject.SetActive(false);
        sentences = new Queue<string>();
        //Trigger();
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
                dialogueIndex++;
                sentences.Enqueue(sentence);
                //line = sentence;
                //DialogueArray = new DialogueArray();
                GetDialogueInfo(dialogueArray);
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
        prop.gameObject.SetActive(false);
        StartPlay();
    }

    public void SetupSprites()
    {
        expressions = Resources.LoadAll("storymode", typeof(Sprite)).Cast<Sprite>().ToArray();

        for (int i = 0; i < expressions.Length; i++)
        {
            if (expressions[i].name == propName)
            {
                Debug.Log("Sprite is set");
                prop.GetComponent<UnityEngine.UI.Image>().sprite = expressions[i];
            }
        }
        //E.GetComponent<UnityEngine.UI.Image>().sprite = sprites[i];
    }

    public void GetDialogueInfo(DialogueArray dialogueArray)
    {   /*if (currentLine == dialogue.sentence[i])
        if(currentIndex == string.Empty)
        {
            propName = dialogueArray.propName;
            index = (int)expressions.GetValue(index);
            SetupSprites();
            ChangeFace(index);
        }*/
        propName = dialogueArray.propName;
        //index = (int)expressions.GetValue(index);
        SetupSprites();
        //ChangeFace(index);
        prop.gameObject.SetActive(true);
    }

    public void ChangeFace(int index)
    {
        for (int i = 0; i < expressions.Length; i++)
        {
            if (i == index)
            {
                //E1.GetComponent<SpriteRenderer>().sprite = sprites[i];
                currentFace.GetComponent<Image>().sprite = expressions[i];
            };
        }
    }

    public void StartPlay()
    {   
        db.gameObject.SetActive(false);
        visSim.gameObject.SetActive(true);
    }
}