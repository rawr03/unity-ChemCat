using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class STOPSM : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        // Assuming you have an AudioManager attached to a GameObject with the PlaySFX method
        GetComponent<Button>().onClick.AddListener(MusicMuted);
    }

    private void MusicMuted()
    {
        AudioManager.Instance.musicSource.Stop();
    }
}
