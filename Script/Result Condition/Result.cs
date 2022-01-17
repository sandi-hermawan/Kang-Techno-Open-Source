using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Result : MonoBehaviour
{
    //Mengambil data yang ada di UI complete screen yang ada diGameplay
    public TextMeshProUGUI Complete_JumlahKoin;
    public TextMeshProUGUI Complete_JumlahSkor;
    

    //Mengambil data yang ada di UI Game Over screen yang ada diGameplay
    public TextMeshProUGUI Failed_JumlahKoin;
    public TextMeshProUGUI Failed_JumlahSkor;


    //Value yang akan disimpan
    public int R_JumlahKoin;
    public int R_JumlahSkor;
    public int R_Level;

    //Value yang akan dikirim ke mainmenu
    public static int RealCoinResult;
    public static int RealSkorResult;
    public static int RealLevelResult;
    public static int RealHealthResult;


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
    
    private void Start()
    {
        //Mengecek data R_Jumlah_Koin yang ada penyimpanan data 
        ResultData data = SaveSystem_Result.LoadPlayer();
        LoadData();
        //Debug.Log("Sekarang anda masuk ke Level = " + RealLevelResult);
        //Debug.Log("Jumlah koin pertama dari data base = " + data.R_JumlahKoin);
        
    }

     public void LoadData()
    {
        ResultData data = SaveSystem_Result.LoadPlayer();
        Health_1 = data.Health_1;
        Health_2 = data.Health_2;
        Health_3 = data.Health_3;
        Health_4 = data.Health_4;
        Health_5 = data.Health_5;

        Totalscore_1 = data.Totalscore_1;
        Totalscore_2 = data.Totalscore_2;
        Totalscore_3 = data.Totalscore_3;
        Totalscore_4 = data.Totalscore_4;
        Totalscore_5 = data.Totalscore_5;
    }
    private void Update()
    {
        //Melakukkan pengulangan unutk fungsi SetDataToPanels();
        SetDataToPanels();
    }

    public void SetDataToPanels()
    {
        //mengambil data jumlah koin dan jumlah skor yang nantinya di tampilkan ke Complete Screen
        if(RealLevelResult == 0)
        {
        }
        else if(RealLevelResult == 1 || RealLevelResult == 2)
        {
            string nol = "0";
            Complete_JumlahKoin.text = Player_1Jalur.numberOfCoin.ToString();
            Complete_JumlahSkor.text = Score.ScoretextResult;
            RealHealthResult = Player_1Jalur.Health;

            //mengambil data jumlah koin dan jumlah skor yang nantinya di tampilkan ke Game Over Screen
            Failed_JumlahKoin.text = Player_1Jalur.numberOfCoin.ToString();
            Failed_JumlahSkor.text = Score.ScoretextResult;
        }
        else
        {
            Complete_JumlahKoin.text = Player_2Jalur.numberOfCoin.ToString();
            Complete_JumlahSkor.text = Score.ScoretextResult;
            RealHealthResult = Player_2Jalur.Health;

            //mengambil data jumlah koin dan jumlah skor yang nantinya di tampilkan ke Game Over Screen
            Failed_JumlahKoin.text = Player_2Jalur.numberOfCoin.ToString();
            Failed_JumlahSkor.text = Score.ScoretextResult;
            
        }
        
    }
    public void GameOverRestart()
    {
        ResultData data = SaveSystem_Result.LoadPlayer();

        R_JumlahKoin = data.R_JumlahKoin + int.Parse(Complete_JumlahKoin.text);
        SaveSystem_Result.SavePlayer(this);
    }

 
    public void GameOverExit()
    {
        ResultData data = SaveSystem_Result.LoadPlayer();

        RealCoinResult = data.R_JumlahKoin + int.Parse(Complete_JumlahKoin.text);
        R_Level = R_Level;
        RealLevelResult = 0;
        SaveSystem_Result.SavePlayer(this);
    }  


    public void GameCompleteRestart()
    {
        ResultData data = SaveSystem_Result.LoadPlayer();

        R_JumlahKoin = data.R_JumlahKoin + int.Parse(Complete_JumlahKoin.text);
        SaveSystem_Result.SavePlayer(this);

    }
    public void PauseExit()
    {
        RealLevelResult = 0;
        SaveSystem_Result.SavePlayer(this);
    }  

    public void GameCompleteExit()
    {
        ResultData data = SaveSystem_Result.LoadPlayer();

        RealCoinResult = data.R_JumlahKoin + int.Parse(Complete_JumlahKoin.text);
        
        RealLevelResult = RealLevelResult;
        SaveSystem_Result.SavePlayer(this);


        Debug.Log("Data yang disimpan adalah Level = " + RealLevelResult);
        if(RealLevelResult == 1)
        {
            Totalscore_1 = int.Parse(Complete_JumlahSkor.text);
            Health_1 = RealHealthResult;
            SaveSystem_Result.SavePlayer(this);

            RealLevelResult = 0;
        }
        else if(RealLevelResult == 2)
        {
            Totalscore_2 = int.Parse(Complete_JumlahSkor.text);
            Health_2 = RealHealthResult;
            SaveSystem_Result.SavePlayer(this);

            RealLevelResult = 0;
        }
        else if(RealLevelResult == 3)
        {
            Totalscore_3 = int.Parse(Complete_JumlahSkor.text);
            Health_3 = RealHealthResult;
            SaveSystem_Result.SavePlayer(this);

            RealLevelResult = 0;
        }
        else if(RealLevelResult == 4)
        {
            
            Totalscore_4 = int.Parse(Complete_JumlahSkor.text);
            Health_4 = RealHealthResult;
            SaveSystem_Result.SavePlayer(this);

            RealLevelResult = 0;
        }
        else if(RealLevelResult == 5)
        {
            Totalscore_5 = int.Parse(Complete_JumlahSkor.text);
            Health_5 = RealHealthResult;
            SaveSystem_Result.SavePlayer(this);

            RealLevelResult = 0;
        }
        else
        {
            Debug.LogError("Data Tidak berhasil Disimpan");
        }
    }


}
