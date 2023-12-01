using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundsfx : MonoBehaviour
{
    public void Checkpointsfx()
    {
        AudioManager.Instance.PlaySFX("Checkpoint");
    }

    public void EggCracksfx()
    {
        AudioManager.Instance.PlaySFX("EggCrack");
    }

    public void Yaysfx()
    {
        AudioManager.Instance.PlaySFX("Yay");
    }

    public void LeavesRustlesfx()
    {
        AudioManager.Instance.PlaySFX("LeavesRustle");
    }

    public void Meowsfx()
    {
        AudioManager.Instance.PlaySFX("Meow");
    }

    public void NomNomNomsfx()
    {
        AudioManager.Instance.PlaySFX("NomNomNom");
    }

    public void BirdsSingingsfx()
    {
        AudioManager.Instance.PlaySFX("BirdsSinging");
    }

    public void WingsFluttersfx()
    {
        AudioManager.Instance.PlaySFX("Wings");
    }

    public void StopSFX()
    {
        AudioManager.Instance.sfxSource.Stop();
    }
}
