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
        Highscore = player.Highscore;


        Easy = new int[10];
        Easy[1] = player.Easy[1];
        Easy[2] = player.Easy[2];
        Easy[3] = player.Easy[3];
        Easy[4] = player.Easy[4];
        Easy[5] = player.Easy[5];
        Easy[6] = player.Easy[6];
        Easy[7] = player.Easy[7];
        Easy[8] = player.Easy[8];
        Easy[9] = player.Easy[9];
        Easy[10] = player.Easy[10];


        Medium = new int[10];
        Medium[1] = player.Medium[1];
        Medium[2] = player.Medium[2];
        Medium[3] = player.Medium[3];
        Medium[4] = player.Medium[4];
        Medium[5] = player.Medium[5];
        Medium[6] = player.Medium[6];
        Medium[7] = player.Medium[7];
        Medium[8] = player.Medium[8];
        Medium[9] = player.Medium[9];
        Medium[10] = player.Medium[10];

        Hard = new int[10];
        Hard[1] = player.Hard[1];
        Hard[2] = player.Hard[2];
        Hard[3] = player.Hard[3];
        Hard[4] = player.Hard[4];
        Hard[5] = player.Hard[5];
        Hard[6] = player.Hard[6];
        Hard[7] = player.Hard[7];
        Hard[8] = player.Hard[8];
        Hard[9] = player.Hard[9];
        Hard[10] = player.Hard[10];
    }
}
