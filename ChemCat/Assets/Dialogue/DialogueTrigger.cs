using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueArray[] dialogueArray;
    //public Matrix[][] matrix;
    //public DialogueInfoList dialogueInfoList;
    [SerializeField] private Animator myAnimationControl;
    public GameObject molecule;
    //public int convoLine = 0;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

        for(int i = 0; i < dialogueArray.Length; i++)
        {
            FindObjectOfType<DialogueManager>().GetDialogueInfo(dialogueArray[i]);
        }
    }

    public void TriggerCutscene()
    {
        FindObjectOfType<CutsceneManager>().StartDialogue(dialogue);

        for (int i = 0; i < dialogueArray.Length; i++)
        {
            FindObjectOfType<DialogueManager>().GetDialogueInfo(dialogueArray[i]);
        }
    }

    /*
    public void TrigConvo(int convoLine)
    {
        convoLine = 1;
        Debug.Log("This is line " + convoLine);

        if (convoLine == 3)
        {
            molecule.SetActive(true);
            myAnimationControl.SetInteger("line", convoLine);
        }
        else
        {
            myAnimationControl.SetInteger("line", convoLine);
        }
    }*/
}
