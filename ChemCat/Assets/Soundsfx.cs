using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundsfx : MonoBehaviour
{
    public void BirdsSingingsfx()
    {
        AudioManager.Instance.PlaySFX("BirdsSinging");
    }
    public void Checkpointsfx()
    {
        AudioManager.Instance.PlaySFX("Checkpoint");
    }

    public void Correctsfx()
    {
        AudioManager.Instance.PlaySFX("Correct");
    }

    public void EggCracksfx()
    {
        AudioManager.Instance.PlaySFX("EggCrack");
    }

    public void GameOversfx()
    {
        AudioManager.Instance.PlaySFX("GameOver");
    }

    public void LeavesRustlesfx()
    {
        AudioManager.Instance.PlaySFX("LeavesRustle");
    }
    public void LevelCompletesfx()
    {
        AudioManager.Instance.PlaySFX("LevelComplete");
    }

    public void Meowsfx()
    {
        AudioManager.Instance.PlaySFX("Meow");
    }

    public void NomNomNomsfx()
    {
        AudioManager.Instance.PlaySFX("NomNomNom");
    }

    public void WingsFluttersfx()
    {
        AudioManager.Instance.PlaySFX("Wings");
    }
    public void Whooshfx()
    {
        AudioManager.Instance.PlaySFX("Whoosh");
    }

    public void Yaysfx()
    {
        AudioManager.Instance.PlaySFX("Yay");
    }

    public void StopSFX()
    {
        AudioManager.Instance.sfxSource.Stop();
    }
}
