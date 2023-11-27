using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
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
    public string difficulty;
    void Start()
    {
        //visSim.SetActive(false);
        //prop.SetActive(false);
        index = 0;
        sentences = new Queue<string>();
        
    }

    public void GStartDialogue(Dialogue dialogue)
    {
        if (attempt == 0)
        {
            //AudioManager.Instance.PlaySFX("GameOverAnim1");
            Debug.Log("Starting dialogue for problem #" + dialogue.problem);
            //dialogueArray = new DialogueArray();
            Debug.Log(index);
            sentences.Clear();

            foreach (string sentence in dialogue.sentences)
            {
                sentences.Enqueue(sentence);
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
        index++;
        //Debug.Log(difficulty);
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        Anim();
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
        Debug.Log(difficulty);
        if (difficulty == "Easy")
        {
            faces = Resources.LoadAll<Sprite>("sp_egg");
            for (int i = 0; i < faces.Length; i++)
            {
                if (i == dialogueIndex)
                {
                    egg.GetComponent<UnityEngine.UI.Image>().sprite = faces[i];
                }
            }
        }
        else if (difficulty == "Medium")
        {
            faces = Resources.LoadAll<Sprite>("sp_caterpillar");
            for (int i = 0; i < faces.Length; i++)
            {
                if (i == dialogueIndex)
                {
                    egg.GetComponent<UnityEngine.UI.Image>().sprite = faces[i];
                }
            }
        }
        else
        {
            faces = Resources.LoadAll<Sprite>("pupa");
            egg.GetComponent<UnityEngine.UI.Image>().sprite = faces[0];
        }
    }

    public void Anim()
    {
        if(index == 0 || index == 1 || index == 2 || index == 3 || 
           index == 4 || index == 5 || index == 6)
        {
            GChangeFace(4);
        }
        else if(index == 7)
        {
            GChangeFace(1);
        }
        else
        {
            GChangeFace(2);
        }
    }

    public void GOverSFX()
    {
        AudioManager.Instance.PlaySFX("GameOverAnim1"); 
    }
}

/*ChemCat Face List:

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