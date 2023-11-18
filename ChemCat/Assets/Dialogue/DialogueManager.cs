using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText; 
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
        //Trigger();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting dialogue for problem #" + dialogue.problem);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        
        if(sentences.Count == 0)
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
            yield return null;
        }
    }

    void EndDialogue()
    {
        Debug.Log("End");
    }
    // Update is called once per frame
}
