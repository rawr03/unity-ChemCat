using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string CheckPoint;
    public int[] Easy;
    public int[] Medium;
    public int[] Hard;
    public int Highscore;

    public PlayerData(Player player)
    {
        CheckPoint = player.CheckPoint;
        Easy = player.Easy;
        Medium = player.Medium; 
        Hard = player.Hard;
        Highscore = player.Highscore;
    }
}
