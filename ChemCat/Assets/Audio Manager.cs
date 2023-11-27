using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public Sound[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    private bool isMusicMuted = false;
    private bool isSFXMuted = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("Object is Not Destroyed");
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("BGMusic");
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }

    public void PlaySFX(string name, bool loop = false, float delay = 0f)
    {
        Invoke("PlayDelayedSFX", delay);
        Sound s = Array.Find(sfxSounds, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            sfxSource.clip = s.clip; 
            sfxSource.loop = loop;
        }
    }
    private void PlayDelayedSFX()
    {
        sfxSource.Play();
    }

    public void StopSFX()
    {
        sfxSource.Stop();
    }

    public void MuteMusic()
    {
        if (musicSource != null)
        {
            isMusicMuted = !isMusicMuted;
            musicSource.mute = isMusicMuted;
        }
        else
        {
            Debug.Log("musicSource is null");
        }
    }

    public void MuteSfx()
    {
        if (sfxSource != null)
        {
            isSFXMuted = !isSFXMuted;
            sfxSource.mute = isSFXMuted;
        }
        else
        {
            Debug.Log("sfxSource is null");
        }
    }

    public bool IsMusicMuted()
    {
        return isMusicMuted;
    }

    public bool IsSFXMuted()
    {
        return isSFXMuted;
    }

    public void UnmuteMusic()
    {
        if (musicSource != null)
        {
            isMusicMuted = false;
            musicSource.mute = false;

            if (!musicSource.isPlaying)
            {
                musicSource.Play();
            }
        }
    }

    public void UnmuteSfx()
    {
        if (sfxSource != null)
        {
            isSFXMuted = false;
            sfxSource.mute = false;

            if (!sfxSource.isPlaying)
            {
                sfxSource.Play();
            }
        }
    }
}
