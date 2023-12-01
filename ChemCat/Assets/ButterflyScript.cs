using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButterflyScript : MonoBehaviour
{
    private int convoLine = 0;
    public void TrigUpdate()
    {
        Debug.Log(convoLine);

        if (convoLine == 1)
        {
            AudioManager.Instance.PlaySFX("Sparkle");
        }
        else if (convoLine == 2)
        {
            AudioManager.Instance.PlaySFX("Yay");
        }
        convoLine++;
    }
}
