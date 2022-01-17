using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MainMenuData 
{
    //Untuk menentukkan atau set data
    //Untuk di Panel Welcome
    public bool WelcomePanelActive;

    //Untuk di Main menu
    public int RealCoin;
    public static int RealCoinResult;
    public int RealMagnet;
    public int RealSepatu;
    

    //Untuk di Panel Misi
    public bool Misi_1_Complete;
    public bool Misi_2_Complete;
    public bool Misi_3_Complete;
    public bool Misi_4_Complete;

    //Unutk Panel Achievement
    public bool Achievement_1_Complete;
    public bool Achievement_2_Complete;
    public bool Achievement_3_Complete;

    //Untuk di panel Me Character
    public string R_MeCharacterYangDipilih_Nama;
    public string R_MeCharacterYangDipilih_TextStatus;
    public bool R_MeCharacterYangDipilih_Status;

    public bool R_MeCharacter1_Status;
    public bool R_MeCharacter2_Status;

    //Untuk Di panel Character Shop
    public string R_CharacterYangDipilih_Nama;
    public int R_CharacterYangDipilih_Harga;
    public bool R_CharacterYangDipilih_Status;

    public bool R_Character1_Status;
    public bool R_Character2_Status;

    //Untuk Di panel Item Shop
    public string R_ItemYangDipilih_Nama;
    public int R_ItemYangDipilih_Harga;
    public int R_ItemYangDipilih_Jumlah;

    public int R_Magnet_Jumlah;
    public int R_Sepatu_Jumlah;

    public bool R_Magnet_Status;
    public bool R_Sepatu_Status;

    //Untuk Di Panel Upgrade Shop
    public int RealUpgradeCostSkate;
    public int RealUpgradeLevelSkate;
    public int RealUpgradeCostSepatu;
    public int RealUpgradeLevelSepatu;
    
    
    public MainMenuData(MainMenu mainmenu )
    {
        //Welcome 
        WelcomePanelActive = mainmenu.WelcomePanelActive;

        //MainMenu
        RealCoin = mainmenu.RealCoin;
        RealMagnet = mainmenu.RealMagnet;
        RealSepatu = mainmenu.RealSepatu;

        //Misi
        Misi_1_Complete = mainmenu.Misi_1_Complete;
        Misi_2_Complete = mainmenu.Misi_2_Complete;
        Misi_3_Complete = mainmenu.Misi_3_Complete;
        Misi_4_Complete = mainmenu.Misi_4_Complete;


        //Achievement
        Achievement_1_Complete = mainmenu.Achievement_1_Complete;
        Achievement_2_Complete = mainmenu.Achievement_2_Complete;
        Achievement_3_Complete = mainmenu.Achievement_3_Complete;

        //Me Character
        R_MeCharacter1_Status = mainmenu.R_MeCharacter1_Status;
        R_MeCharacter2_Status = mainmenu.R_MeCharacter2_Status;

        R_MeCharacterYangDipilih_Nama = mainmenu.R_MeCharacterYangDipilih_Nama;
        R_MeCharacterYangDipilih_TextStatus = mainmenu.R_MeCharacterYangDipilih_TextStatus;
        R_MeCharacterYangDipilih_Status = mainmenu.R_MeCharacterYangDipilih_Status;


        //Charactershop
        R_Character1_Status = mainmenu.R_Character1_Status;
        R_Character2_Status = mainmenu.R_Character2_Status;

        R_CharacterYangDipilih_Nama = mainmenu.R_CharacterYangDipilih_Nama;
        R_CharacterYangDipilih_Harga = mainmenu.R_CharacterYangDipilih_Harga;
        R_CharacterYangDipilih_Status = mainmenu.R_CharacterYangDipilih_Status;

        //ItemShop
        R_Magnet_Jumlah = mainmenu.R_Magnet_Jumlah;
        R_Sepatu_Jumlah = mainmenu.R_Sepatu_Jumlah;

        R_Magnet_Status = mainmenu.R_Magnet_Status;
        R_Sepatu_Status = mainmenu.R_Sepatu_Status;

        R_ItemYangDipilih_Nama = mainmenu.R_ItemYangDipilih_Nama;
        R_ItemYangDipilih_Harga = mainmenu.R_ItemYangDipilih_Harga;
        R_ItemYangDipilih_Jumlah = mainmenu.R_ItemYangDipilih_Jumlah;

        //Upgrade
        RealUpgradeCostSkate = mainmenu.RealUpgradeCostSkate;
        RealUpgradeLevelSkate = mainmenu.RealUpgradeLevelSkate;
        RealUpgradeCostSepatu = mainmenu.RealUpgradeCostSepatu;
        RealUpgradeLevelSepatu = mainmenu.RealUpgradeLevelSepatu;


    }
}
