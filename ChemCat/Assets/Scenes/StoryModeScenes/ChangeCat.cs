using UnityEngine;
using UnityEngine.UI;

public class ChangeCat : MonoBehaviour
{
    private int convoLine = 0;
    public int index = 0;
    public Sprite[] Sp_eggs;
    public GameObject charCenter, sprite;

    // Start is called before the first frame update
    public void LoadSprite()
    {
        Sp_eggs = Resources.LoadAll<Sprite>("sp_caterpillar");
    }

    public void Next()
    {
        convoLine++;
    }
    public void ChangeSprite(int index)
    {
        for (int i = 0; i < Sp_eggs.Length; i++)
        {
            if (i == index)
            {
                charCenter.GetComponent<Image>().sprite = Sp_eggs[i];
            };
        }
    }

    public void TrigUpdate()
    {
        LoadSprite();
        sprite.SetActive(false);
        charCenter.SetActive(true);
        //eggCenter.SetActive(false);
        Debug.Log(convoLine);

        if (convoLine == 0)
        {
            ChangeSprite(1);
            AudioManager.Instance.PlaySFX("Yay");
        }
        else if (convoLine == 1)
        {
            ChangeSprite(0);
            AudioManager.Instance.PlaySFX("Sparkle", false, 1f);
        }
        else if (convoLine == 2)
        {
            ChangeSprite(2);
            AudioManager.Instance.PlaySFX("Wow");
        }
        else if (convoLine == 3)
        {
            ChangeSprite(1);
            AudioManager.Instance.PlaySFX("LevelComplete", false, 1f);
        }
        else if (convoLine == 4)
        {
            ChangeSprite(0);
            
        }
        else if (convoLine == 5)
        {
            ChangeSprite(2);
            AudioManager.Instance.PlaySFX("Dundundun", false, 0.5f);
        }
        convoLine++;
    }

    public void Start()
    {
        
    }
}
