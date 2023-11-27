using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueArray[] dialogueArray;
    //public DialogueArray[] dialogueArray;
    //public Matrix[][] matrix;
    //public DialogueInfoList dialogueInfoList;
    [SerializeField] private Animator myAnimationControl;
    public GameObject molecule;
    //public int convoLine = 0;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void TriggerCutscene()
    {
        FindObjectOfType<CutsceneManager>().StartDialogue(dialogue);
    }

    public void TriggerGameOver()
    {
        FindObjectOfType<GameOver_dialogue>().GStartDialogue(dialogue);
    }
}