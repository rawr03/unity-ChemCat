using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        private TextMeshProUGUI textHolder;
        [SerializeField] private string input;

        private void Awake()
        {
            textHolder = GetComponent<TextMeshProUGUI>();
            StartCoroutine(WriteText(input, textHolder));
        }
    }
}

    
