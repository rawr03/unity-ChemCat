using TMPro;
using UnityEngine;

public class Subscript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject sb, Input;
    string genInput;

    BuildEq bEq;

    public void InputSub()
    {
        bEq = FindObjectOfType<BuildEq>();
        genInput = sb.GetComponentInChildren<TextMeshProUGUI>().text;
        bEq.UpdateInput(genInput);
    }

}
