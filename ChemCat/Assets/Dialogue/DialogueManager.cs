using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

/*
 * smile;
    public Sprite openmouthsmile;
    public Sprite angry;
    public Sprite sad;
    public Sprite scared;
    public Sprite smart;
    public Sprite cat;
    public Sprite meh; 
 */
public enum Expression
{
    smile,
    openmouthsmile,
    angry,
    sad,
    scared,
    smart,
    cat,
    meh
}

/*
private Character caaa;
public Stage Speaker
{
    get { return AudioSpeakerMode; }
}*/

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;
    //private int Index = 0;
    public float DialogueSpeed;
    public Image Face;


    public Expression expresssion;

    public Expression Expression
    {
        set
        {
            Sprite sprite;
            if (value == Expression.smile)
            {
                //sprite = Stage.smile;
            }
            else if (value == Expression.openmouthsmile)
            {
                //sprite = Stage.openmouthsmile;
            }
            else if (value == Expression.angry)
            {
                //sprite = Stage.angry;
            }
            else if (value == Expression.sad)
            {
                //sprite = Stage.sad;
            }
            else if (value == Expression.scared)
            {
                //sprite = Stage.scared;
            }   
            else if (value == Expression.smart)
            {
                //sprite = Stage.smart;
            }
            else if (value == Expression.cat)
            {
                //sprite = Stage.cat;
            }
            else
            {
                //sprite = Stage.meh;
            }
            //Stage.sprite = sprite;
        }
    }

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
            yield return new WaitForSeconds(DialogueSpeed);
        }
    }

    void EndDialogue()
    {
        Debug.Log("End");
    }
    // Update is called once per frame
}
