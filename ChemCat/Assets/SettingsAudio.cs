using UnityEngine;
using UnityEngine.UI;

public class SettingsAudio : MonoBehaviour
{
    public Button MuteUnmute;
    public Sprite MusicOn, MusicOff;

    public Button OnOff;
    public Sprite SfxOn, SfxOff;

    //private bool isMusicMuted = false;
    //private bool isSFXMuted = false;
    private void Start()
    {
        UpdateSprite();
        MuteUnmute.onClick.AddListener(ToggleMute);
        OnOff.onClick.AddListener(ToggleSFX);
    }

    private void ToggleMute()
    {
        AudioManager.Instance.MuteMusic();
        UpdateSprite();
    }

    private void ToggleSFX()
    {
        AudioManager.Instance.MuteSfx();
        UpdateSprite();
    }

    public void UpdateSprite()
    {
        Debug.Log("Button is Preessed");
        bool isMusicMuted = AudioManager.Instance.IsMusicMuted();
        bool isSFXMuted = AudioManager.Instance.IsSFXMuted();

        //MuteUnmute.image.sprite = isMusicMuted ? MusicOff : MusicOn;
        //OnOff.image.sprite = isSFXMuted ? SfxOff: SfxOn;
        MuteUnmute.image.sprite = isMusicMuted? MusicOff : MusicOn;
        OnOff.image.sprite = isSFXMuted ? SfxOff : SfxOn;
        /*
        if (isMusicMuted == true)
        {
            // Change the sprite based on the mute state for music
            MuteUnmute.image.sprite = MusicOff;
            
        }
        else if (isSFXMuted == true) 
        {
            MuteUnmute.image.sprite = MusicOn;
        }
        
        
        if (isSFXMuted == true)
        {
            // Change the sprite based on the mute state for SFX
            OnOff.image.sprite = SfxOff;
            //isSFXMuted ? SfxOff : SfxOn;
        }
        else if(isSFXMuted == false)
        {
            OnOff.image.sprite = SfxOn;
        }*/

    }

    public void Update()
    {
        //UpdateSprite();
    }
}
