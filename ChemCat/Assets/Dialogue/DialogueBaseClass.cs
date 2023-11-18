using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueBaseClass : MonoBehaviour
    {
        protected IEnumerator WriteText(string input, TextMeshProUGUI textholder)
        {
            for (int i = 0; i < input.Length; i++)
            {
                textholder.text += input[i];
                yield return new WaitForSeconds(0.1f);
            }
        }

    }

}