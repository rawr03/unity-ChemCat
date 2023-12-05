using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PupaIntroScript : MonoBehaviour
{
    private int convoLine = 0;
    public void TrigUpdate()
    {
        Debug.Log(convoLine);

        if (convoLine == 0)
        {
            AudioManager.Instance.PlaySFX("Yawn", false, 1f);
        }
        convoLine++;
    }
}
