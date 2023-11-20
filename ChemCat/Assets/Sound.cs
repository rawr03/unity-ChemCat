using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;

[System.Serializable]
public class Sound 
{
    public string name;
    public AudioClip clip; 


    /*
    [Header("----------Audio Source----------")]
    [SerializeField] AudioSource BGMusic;
    [SerializeField] AudioSource Sfx;

    [Header("----------Audio Clip----------")]
    public AudioClip BG; 
    public AudioClip Tiktok;
    public AudioClip Correct;
    public AudioClip Wrong;
    public AudioClip TimesUp;
    public AudioClip LevelComplete;

    private void Start()
    {
        BGMusic.clip = Tiktok; 
        BGMusic.Play();
    }

   

    //playing correct
    public void PlaySFX(AudioClip clip)
    {
        Sfx.PlayOneShot(clip);
    }
    
   /*public void PauseSFX()
    {
        AudioSource allAudioSources = FindAnyObjectByType<AudioSource>();
        foreach(AudioSource a in allAudioSources)
        {
            if (a.isPlaying) a.Pause();
            else a.UnPause();
        }
    }*/

    /*public void MuteSFX()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (AudioClip.Equals
        }
    }*/





}
