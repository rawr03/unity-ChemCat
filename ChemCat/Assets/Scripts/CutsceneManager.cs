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
//using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;
using UnityEngine.U2D;
using UnityEngine.UIElements;


public class CutsceneManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;
    public float DialogueSpeed;

    public int attempt;
    public Sprite[] sprites;
    //private Sprite sprite;
    public int dialogueIndex = 0;

    // Sprite
    public GameObject CurrentFace;
    private string propName;

    private int SceneIndex;
   
    //public DialogueArray dialogueArray;

    // Start is called before the first frame update
    void Start()
    {
        //visSim.gameObject.SetActive(false);
        //prop.gameObject.SetActive(false);
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
        SceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (SceneIndex == 23)
        {
            AudioManager.Instance.PlayMusic("BGMusic");
            SceneManager.LoadScene("Main Menu");
        }
        else
        {
            Debug.Log("End");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        //prop.gameObject.SetActive(false);
        //StartPlay();
    }

    public void SetupSprites()
    {
        sprites = Resources.LoadAll("storymode", typeof(Sprite)).Cast<Sprite>().ToArray();

        for (int i = 0; i < sprites.Length; i++)
        {
            if (sprites[i].name == propName)
            {
                Debug.Log("Sprite is set");
                //prop.GetComponent<UnityEngine.UI.Image>().sprite = sprites[i];
            }
        }
        //E.GetComponent<UnityEngine.UI.Image>().sprite = sprites[i];
    }

    public void GetDialogueInfo(DialogueArray dialogueArray)
    {
        SetupSprites();
        //ChangeSprite();
        //prop.gameObject.SetActive(true);
        propName = dialogueArray.propName;
    }

    /*
    public static int GetIndex(this Enum value)
    {
        Array values = Enum.GetValues(value.GetType());
        return Array.IndexOf(values, value);
    }*/

    
    public void ChangeSprite()
    {
        sprites = Resources.LoadAll<Sprite>("sp_egg").ToArray();
        /*
        for (int i = 0; i < sprites.Length; i++)
        {
            if (sprites[i] == indexNumber)
            {
                Debug.Log("Sprite is set");
                CurrentFace.GetComponent<UnityEngine.UI.Image>().sprite = sprites[i];
            }
        }*/
    }
    //expression.ToSafeString();
    //Debug.Log(expression.ToString());

    //Sname = string;
    /*
    //string[] names = System.Enum.GetNames(typeof(Expression));
    for (int i = 0; i < sprites.Length; i++)
    {
        if ( ==)
        {
            Debug.Log("Sprite is set");
            CurrentFace.GetComponent<UnityEngine.UI.Image>().sprite = sprites[i];
        }
    }
    //expression = DialogueArray.expression
    //if(expression)
    //CurrentFace.GetComponent<UnityEngine.UI.Image>().sprite = expression;
    */
}