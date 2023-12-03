using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class CatDialogue : MonoBehaviour
{
    private int convoLine = 0;
    public void TrigUpdate()
    {
        Debug.Log(convoLine);

        if (convoLine == 0)
        {
            AudioManager.Instance.PlaySFX("Yay", false, 1f);
        }
        else if (convoLine == 1)
        {
            AudioManager.Instance.PlaySFX("Sparkle", false, 0.5f);
        }
        else if (convoLine == 2)
        {
            AudioManager.Instance.PlaySFX("Wow");
        }
        convoLine++;
    }
}
