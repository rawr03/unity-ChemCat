using UnityEngine;
using UnityEngine.UI;

public class UnlockDiff : MonoBehaviour
{

    public Button Medium, Hard, Extreme;
    // Start is called before the first frame update
    void Start()
    {
        Medium.interactable = false;
        Hard.interactable = false;
        Extreme.interactable = false;
        Unlock();
    }

    public void Unlock()
    {
        Debug.Log(PlayerPrefs.GetInt("LevelPassedE"));
        Debug.Log(PlayerPrefs.GetInt("LevelPassedmM"));
        if (PlayerPrefs.GetInt("LevelPassedE") >= 5)
        {
            Medium.interactable = true;
        }
        if (PlayerPrefs.GetInt("LevelPassedM") >= 5)
        {
            Hard.interactable = true;
        }
        if (PlayerPrefs.GetInt("LevelPassedH") >= 10)
        {
            Extreme.interactable = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
       Unlock();
    }
}
