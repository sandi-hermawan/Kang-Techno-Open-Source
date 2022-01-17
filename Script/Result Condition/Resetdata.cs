using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resetdata : Result
{
    public static int LevelScene;
    void Getdata()
    {
        R_JumlahKoin = 0;
        R_JumlahSkor = 0;
        R_Level = LevelScene;
        SaveSystem_Result.SavePlayer(this);

    }

    public void GetDataInGameplayDefault()
    {
        Getdata();
    }
}
