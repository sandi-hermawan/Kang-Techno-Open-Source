using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ResultData
{
    public int R_JumlahKoin;
    public int R_JumlahSkor;
    public int R_Level;

    //Simpan data level 1
    public int Health_1;
    public int Totalscore_1;

    //Simpan data level 2
    public int Health_2;
    public int Totalscore_2;

    //Simpan data level 3
    public int Health_3;
    public int Totalscore_3;

    //Simpan data level 4
    public int Health_4;
    public int Totalscore_4;

    //Simpan data level 5
    public int Health_5;
    public int Totalscore_5;

    public ResultData(Result result)
    {
        R_JumlahKoin = result.R_JumlahKoin;
        R_JumlahSkor = result.R_JumlahSkor;
        R_Level = result.R_Level;
        //Simpan data level 1
        Health_1 = result.Health_1; 
        Totalscore_1 = result.Totalscore_1;

        //Simpan data level 2
        Health_2 = result.Health_2;
        Totalscore_2 = result.Totalscore_2;

        //Simpan data level 3
        Health_3 = result.Health_3;
        Totalscore_3 = result.Totalscore_3;

        //Simpan data level 4
        Health_4 = result.Health_4;
        Totalscore_4 = result.Totalscore_4;

        //Simpan data level 5
        Health_5 = result.Health_5;
        Totalscore_5 = result.Totalscore_5;
    }
}
