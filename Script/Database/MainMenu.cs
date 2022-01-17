using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MainMenu : MonoBehaviour
{
    //REGION UI -> digunakan untuk mengambil data/value dari UI yang ada di tampilan.
    #region REGION UI WELCOME PANEL
    [Header("Welcome Panel")]
    public GameObject WelcomePanel;
    public bool WelcomePanelActive = true;
    #endregion

    #region REGION UI TOP MENU
    [Header("Top Menu")]
    public TextMeshProUGUI TextCoin;
    public TextMeshProUGUI TextMagnet;
    public TextMeshProUGUI TextSepatu;
    #endregion

    #region REGION UI TOP MENU Shop
    [Header("Top Menu")]
    public TextMeshProUGUI TextCoinShop;
    public TextMeshProUGUI TextMagnetShop;
    public TextMeshProUGUI TextSepatuShop;
    #endregion

    #region REGION UI MISI 
    [Header("Panel Misi")]
    //Misi Ke 1
    public GameObject Misi_1_Checklist;
    public bool Misi_1_Complete = false;

    //Misi ke 2
    public GameObject Misi_2_Checklist;
    public bool Misi_2_Complete = false;

    //Misi Ke 3
    public GameObject Misi_3_Checklist;
    public bool Misi_3_Complete = false;

    //Misi ke 4
    public GameObject Misi_4_Checklist;
    public bool Misi_4_Complete = false;

    #endregion

    #region REGION UI ACHIEVEMENT
    [Header("Panel Achievement")]
    //Misi Ke 1
    public GameObject Achievement_1_fullBar;
    public bool Achievement_1_Complete = false;

    //Misi ke 2
    public GameObject Achievement_2_fullBar;
    public bool Achievement_2_Complete = false;

    //Misi Ke 3
    public GameObject Achievement_3_fullBar;
    public bool Achievement_3_Complete = false;
    #endregion

    #region  REGION UI LEADERBOARD
    [Header("LeaderBoard")]
    public TextMeshProUGUI Name_Rank1;
    public TextMeshProUGUI TotalScore_Rank1;
    public TextMeshProUGUI Name_Rank2;
    public TextMeshProUGUI TotalScore_Rank2;
    public TextMeshProUGUI Name_Rank3;
    public TextMeshProUGUI TotalScore_Rank3;
    #endregion

    #region REGION UI LEVEL
    //Untuk Panel Level
    [Header("Panel Level")]
    public TextMeshProUGUI TotalScore_Lvl_1;
    public GameObject BintangKiri_lvl_1;
    public GameObject BintangTengah_lvl_1;
    public GameObject Bintangkanan_lvl_1;

    [Header("Level 2")]
    public TextMeshProUGUI TotalScore_Lvl_2;
    public GameObject BintangKiri_lvl_2;
    public GameObject BintangTengah_lvl_2;
    public GameObject Bintangkanan_lvl_2;

    [Header("Level 3")]
    public TextMeshProUGUI TotalScore_Lvl_3;
    public GameObject BintangKiri_lvl_3;
    public GameObject BintangTengah_lvl_3;
    public GameObject Bintangkanan_lvl_3;

    [Header("Level 4")]
    public TextMeshProUGUI TotalScore_Lvl_4;
    public GameObject BintangKiri_lvl_4;
    public GameObject BintangTengah_lvl_4;
    public GameObject Bintangkanan_lvl_4;

    [Header("Level 5")]
    public TextMeshProUGUI TotalScore_Lvl_5;
    public GameObject BintangKiri_lvl_5;
    public GameObject BintangTengah_lvl_5;
    public GameObject Bintangkanan_lvl_5;

    //untuk Panel welcome
    [Header("Panel Welcome")]
    public GameObject panelWelcome;
    #endregion

    #region REGION UI Me
    //Untuk Di panel Me 

    //Character 1
    [Header("(Panel Me) Data Character 1")]
    public TextMeshProUGUI MeCharacter1_Nama;
    public bool MeCharacter1_Status;
    public GameObject MeCharacter1_terkunci;

    //Character 2
    [Header("(Panel Me) Data Character 2")]
    public TextMeshProUGUI MeCharacter2_Nama;
    public bool MeCharacter2_Status;
    public GameObject MeCharacter2_terkunci;

    [Header("(Panel Me) Character Yang dipilih")]
    public TextMeshProUGUI MeCharacterYangDipilih_Nama;
    public TextMeshProUGUI MeCharacterYangDipilih_TextStatus;
    public bool MeCharacterYangDipilih_Status;
    public GameObject MeCharacterYangDipilih_Terkunci;
    #endregion

    #region REGION UI SHOP
    //Character Shop
    [Header("(Panel Shop) Data Character 1")]
    public TextMeshProUGUI Character1_Nama;
    public TextMeshProUGUI Character1_Harga;
    public bool Character1_Status;
    public GameObject Character1_terkunci;

    [Header("(Panel Shop) Data Character 2")]
    public TextMeshProUGUI Character2_Nama;
    public TextMeshProUGUI Character2_Harga;
    public bool Character2_Status;
    public GameObject Character2_terkunci;

    [Header("(Panel Shop) Character Yang dipilih")]
    public TextMeshProUGUI CharacterYangDipilih_Nama;
    public TextMeshProUGUI CharacterYangDipilih_Harga;
    public bool CharacterYangDipilih_Status;

    //Untuk Di Panel Upgrade Shop
    [Header("Panel Upgrade")]
    public TextMeshProUGUI TextUpgradeSkate;
    public TextMeshProUGUI LevelUpgradeSkate;
    public TextMeshProUGUI TextUpgradeSepatu;
    public TextMeshProUGUI LevelUpgradeSepatu;

    //Untuk Di panel Item Shop
    //Magnet
    [Header("(Panel Shop) Data Magnet")]
    public TextMeshProUGUI Magnet_Nama;
    public TextMeshProUGUI Magnet_Harga;
    public TextMeshProUGUI Magnet_Jumlah;
    public GameObject Magnet_Gambar;

    //Sepatu
    [Header("(Panel Shop) Data Sepatu")]
    public TextMeshProUGUI Sepatu_Nama;
    public TextMeshProUGUI Sepatu_Harga;
    public TextMeshProUGUI Sepatu_Jumlah;
    public GameObject Sepatu_Gambar;


    //Set
    [Header("(Panel Shop) Item booster Yang dipilih")]
    public TextMeshProUGUI ItemYangDipilih_Nama;
    public TextMeshProUGUI ItemYangDipilih_Harga;
    public TextMeshProUGUI ItemYangDipilih_Jumlah;

    public GameObject ItemYangDipilih_Magnet_Gambar;
    public GameObject ItemYangDipilih_Sepatu_Gambar;
    #endregion

    #region REGION UI LEVEL 

    [Header("Panel Level ")]
    public GameObject Level_2_Unlock;
    public GameObject Level_2_Lock;
    public GameObject Level_3_Unlock;
    public GameObject Level_3_Lock;
    public GameObject Level_4_Unlock;
    public GameObject Level_4_Lock;
    public GameObject Level_5_Unlock;
    public GameObject Level_5_Lock;

    #endregion

    //REGION DATA ->  Digunakan untuk menyimpan data sementara
    #region REGION DATA MAIN MENU
    //Untuk menentukkan atau set data
    //Untuk di Main menu

    [Header("Penyimpanan data mainmenu")]
    public int RealCoin;
    public int RealMagnet;
    public int RealSepatu;

    //Untuk di Main menu
    public int RealCoinResult;
    public int RealSkorResult;
    public int RealLevelResult;
    public int RealHealthResult;

    #endregion

    #region REGION DATA LeaderBoard
    [Header("Penyimpanan data LeaderBoard")]
    public string R_Name_KangTechno = "Kang Techno";
    public int R_TotalScore_KangTechno = 5000;
    public string R_Name_NengTechno = "Neng Techno";
    public int R_TotalScore_NengTechno = 4500;
    public string R_Name_Player = "Player";
    public int R_TotalScore_Player = 0;
    #endregion

    #region REGION DATA ME

    [Header("Penyimpanan data Panel MeCharacter")]
    //Untuk Dipanel Me Character 

    public string R_MeCharacter1_Nama = "Kang Techno";
    public bool R_MeCharacter1_Status = true;

    public string R_MeCharacter2_Nama = "Neng Techno";
    public bool R_MeCharacter2_Status = false;

    public string R_MeCharacterYangDipilih_Nama;
    public string R_MeCharacterYangDipilih_TextStatus;
    public bool R_MeCharacterYangDipilih_Status;
    #endregion

    #region REGION DATA SHOP

    [Header("Penyimpanan data panel CharacterShop")]
    //Untuk Dipanel Character Shop
    public string R_Character1_Nama = "Kang Techno";
    public int R_Character1_Harga = 0;
    public bool R_Character1_Status = true;

    public string R_Character2_Nama = "Neng Techno";
    public int R_Character2_Harga = 5000;
    public bool R_Character2_Status = false;

    public string R_CharacterYangDipilih_Nama;
    public int R_CharacterYangDipilih_Harga;
    public bool R_CharacterYangDipilih_Status;

    [Header("Penyimpanan data panel ItemShop")]
    //Untuk Di panel Item Shop
    public string R_Magnet_Nama = "Magnet";
    public int R_Magnet_Harga = 1000;
    public int R_Magnet_Jumlah = 0;
    public bool R_Magnet_Status = true;

    public string R_Sepatu_Nama = "Sepatu";
    public int R_Sepatu_Harga = 1000;
    public int R_Sepatu_Jumlah = 0;
    public bool R_Sepatu_Status = false;

    public string R_ItemYangDipilih_Nama;
    public int R_ItemYangDipilih_Harga;
    public int R_ItemYangDipilih_Jumlah;

    [Header("Penyimpanan data panel Upgrade")]
    //Untuk Di Panel Upgrade Shop
    public int RealUpgradeCostSkate = 500;
    public int RealUpgradeLevelSkate = 1;
    public int RealUpgradeCostSepatu = 500;
    public int RealUpgradeLevelSepatu = 1;

    #endregion


    //REGION START 
    #region REGION START, UPDATE
    private void Start()
    {
        LoadData();
        CheckStatusWelcomePanel();
        LoadDataLevel();

        ItemLock();

        RealCoinResult = Result.RealCoinResult;
        RealSkorResult = Result.RealSkorResult;
        RealLevelResult = Result.RealLevelResult;

        SaveData();
        LoadData();
        GetDataBooster();
        AllCheck();
    }
    public void AllCheck()
    {
        CheckLevelStatus();
        CheckUpdatedataItemShop();
        CheckStatusMision();
        CheckStatusAchievement();
        CheckLeaderBoard();
        checkPanelBeliItem();

    }
    private void Update()
    {
        ValueInShop();
    }
    #endregion

    //REGION GET AND SET -> (Get) Digunakan untuk mengambil data yang ada dan (Set) mengubah data sesuai yang ada di penyimpanan data 
    #region REGION GET AND SET
    //Get dan Set Data
    public void GetDataBooster()
    {
        if (SaveSystem_Booster.LoadPlayer() == null)
        {
            Debug.Log("......");
        }
        else
        {
            BoosterData BData = SaveSystem_Booster.LoadPlayer();
            R_Magnet_Jumlah = BData.R_Magnet_Jumlah;
            R_Sepatu_Jumlah = BData.R_Sepatu_Jumlah;
            RealMagnet = R_Magnet_Jumlah;
            RealSepatu = R_Sepatu_Jumlah;
            SaveData();
            LoadData();
        }

    }

    void GetdataUI()
    {
        //Welcome Panel
        WelcomePanelActive = WelcomePanelActive;

        //Mainmenu
        RealCoin = RealCoin + RealCoinResult;
        RealMagnet = R_Magnet_Jumlah;
        RealSepatu = RealSepatu;

        //Panel Misi
        Misi_1_Complete = Misi_1_Complete;
        Misi_2_Complete = Misi_2_Complete;
        Misi_3_Complete = Misi_3_Complete;
        Misi_4_Complete = Misi_4_Complete;

        //Panel Achievement
        Achievement_1_Complete = Achievement_1_Complete;
        Achievement_2_Complete = Achievement_2_Complete;
        Achievement_3_Complete = Achievement_3_Complete;

        //Panel MeCharacter
        R_MeCharacter1_Status = R_MeCharacter1_Status;
        R_MeCharacter2_Status = R_MeCharacter2_Status;
        R_MeCharacterYangDipilih_Nama = R_MeCharacterYangDipilih_Nama;
        R_MeCharacterYangDipilih_TextStatus = R_MeCharacterYangDipilih_TextStatus;
        R_MeCharacterYangDipilih_Status = R_MeCharacterYangDipilih_Status;

        //Panel Charactershop
        R_Character1_Status = R_Character1_Status;
        R_Character2_Status = R_Character2_Status;
        R_CharacterYangDipilih_Nama = R_CharacterYangDipilih_Nama;
        R_CharacterYangDipilih_Harga = R_CharacterYangDipilih_Harga;
        R_CharacterYangDipilih_Status = R_CharacterYangDipilih_Status;

        //Panel Itemshop
        R_Magnet_Jumlah = R_Magnet_Jumlah;
        R_Sepatu_Jumlah = R_Sepatu_Jumlah;
        R_Magnet_Status = R_Magnet_Status;
        R_Sepatu_Status = R_Sepatu_Status;
        R_ItemYangDipilih_Nama = R_ItemYangDipilih_Nama;
        R_ItemYangDipilih_Harga = R_ItemYangDipilih_Harga;
        R_ItemYangDipilih_Jumlah = R_ItemYangDipilih_Jumlah;

        //Panel Upgrade
        RealUpgradeCostSkate = RealUpgradeCostSkate;
        RealUpgradeLevelSkate = RealUpgradeLevelSkate;
        RealUpgradeCostSepatu = RealUpgradeCostSepatu;
        RealUpgradeLevelSepatu = RealUpgradeLevelSepatu;

    }
    void GetdataUIWithoutResult()
    {
        //Welcome Panel
        WelcomePanelActive = WelcomePanelActive;

        //Mainmenu
        RealCoin = RealCoin;
        RealMagnet = R_Magnet_Jumlah;
        RealSepatu = RealSepatu;

        //Panel Misi
        Misi_1_Complete = Misi_1_Complete;
        Misi_2_Complete = Misi_2_Complete;
        Misi_3_Complete = Misi_3_Complete;
        Misi_4_Complete = Misi_4_Complete;

        //Panel Achievement
        Achievement_1_Complete = Achievement_1_Complete;
        Achievement_2_Complete = Achievement_2_Complete;
        Achievement_3_Complete = Achievement_3_Complete;

        //Panel MeCharacter
        R_MeCharacter1_Status = R_MeCharacter1_Status;
        R_MeCharacter2_Status = R_MeCharacter2_Status;
        R_MeCharacterYangDipilih_Nama = R_MeCharacterYangDipilih_Nama;
        R_MeCharacterYangDipilih_TextStatus = R_MeCharacterYangDipilih_TextStatus;
        R_MeCharacterYangDipilih_Status = R_MeCharacterYangDipilih_Status;


        //Panel Charactershop
        R_Character1_Status = R_Character1_Status;
        R_Character2_Status = R_Character2_Status;
        R_CharacterYangDipilih_Nama = R_CharacterYangDipilih_Nama;
        R_CharacterYangDipilih_Harga = R_CharacterYangDipilih_Harga;
        R_CharacterYangDipilih_Status = R_CharacterYangDipilih_Status;

        //Panel Itemshop
        R_Magnet_Jumlah = R_Magnet_Jumlah;
        R_Sepatu_Jumlah = R_Sepatu_Jumlah;
        R_Magnet_Status = R_Magnet_Status;
        R_Sepatu_Status = R_Sepatu_Status;
        R_ItemYangDipilih_Nama = R_ItemYangDipilih_Nama;
        R_ItemYangDipilih_Harga = R_ItemYangDipilih_Harga;
        R_ItemYangDipilih_Jumlah = R_ItemYangDipilih_Jumlah;

        //Panel Upgrade
        RealUpgradeCostSkate = RealUpgradeCostSkate;
        RealUpgradeLevelSkate = RealUpgradeLevelSkate;
        RealUpgradeCostSepatu = RealUpgradeCostSepatu;
        RealUpgradeLevelSepatu = RealUpgradeLevelSepatu;

    }
    void SetdataUI()
    {
        //Panel Welcome
        WelcomePanelActive = WelcomePanelActive;

        //Panel Main Menu
        TextCoin.text = RealCoin.ToString();
        TextMagnet.text = RealMagnet.ToString();
        TextSepatu.text = RealSepatu.ToString();

        //panel Misi
        Misi_1_Complete = Misi_1_Complete;
        Misi_2_Complete = Misi_2_Complete;
        Misi_3_Complete = Misi_3_Complete;
        Misi_4_Complete = Misi_4_Complete;


        //Panel Achievement
        Achievement_1_Complete = Achievement_1_Complete;
        Achievement_2_Complete = Achievement_2_Complete;
        Achievement_3_Complete = Achievement_3_Complete;

        //Panel MeCharacter
        MeCharacter1_Status = R_MeCharacter1_Status;
        MeCharacter2_Status = R_MeCharacter2_Status;
        MeCharacterYangDipilih_Nama.text = R_MeCharacterYangDipilih_Nama.ToString();
        MeCharacterYangDipilih_TextStatus.text = R_MeCharacterYangDipilih_TextStatus;
        MeCharacterYangDipilih_Status = R_MeCharacterYangDipilih_Status;


        //Panel Character Shop
        Character1_Status = R_Character1_Status;
        Character2_Status = R_Character2_Status;
        CharacterYangDipilih_Nama.text = R_CharacterYangDipilih_Nama.ToString();
        CharacterYangDipilih_Harga.text = R_CharacterYangDipilih_Harga.ToString();
        CharacterYangDipilih_Status = R_CharacterYangDipilih_Status;

        //Panel Item Shop
        Magnet_Jumlah.text = R_Magnet_Jumlah.ToString();
        Sepatu_Jumlah.text = R_Sepatu_Jumlah.ToString();

        R_Magnet_Status = R_Magnet_Status;
        R_Sepatu_Status = R_Sepatu_Status;
        ItemYangDipilih_Nama.text = R_ItemYangDipilih_Nama.ToString();
        ItemYangDipilih_Harga.text = R_ItemYangDipilih_Harga.ToString();
        ItemYangDipilih_Jumlah.text = R_ItemYangDipilih_Jumlah.ToString();

        //Panel Upgrade Shop
        TextUpgradeSkate.text = RealUpgradeCostSkate.ToString();
        LevelUpgradeSkate.text = RealUpgradeLevelSkate.ToString();
        TextUpgradeSepatu.text = RealUpgradeCostSepatu.ToString();
        LevelUpgradeSepatu.text = RealUpgradeLevelSepatu.ToString();
    }
    public void SetDefault()
    {
        //berfungsi Untuk Menset data seperti semula (Hanya untuk uji coba, mengecek data apakah berhasil untuk ditambah atau dikurangi)
        // Di bagian Main Menu
        RealCoin = 5000;
        RealMagnet = 0;
        RealSepatu = 0;


        //Dibagian Panel Me Character
        R_MeCharacterYangDipilih_Nama = "";
        R_MeCharacterYangDipilih_TextStatus = "";
        R_MeCharacter1_Status = true;
        R_MeCharacter2_Status = false;
        ItemLockMeCh1();
        ItemLockMeCh2();

        //Dibagian Panel CharacterShop
        R_CharacterYangDipilih_Nama = "";
        R_CharacterYangDipilih_Harga = 0;
        R_Character1_Status = true;
        R_Character2_Status = false;
        ItemLockCh1();
        ItemLockCh2();

        //Di Bagian Panel item shop
        R_ItemYangDipilih_Nama = "";
        R_ItemYangDipilih_Harga = 0;
        R_Magnet_Jumlah = 0;
        R_Sepatu_Jumlah = 0;

        //Di Bagian Panel Upgrade shop
        RealUpgradeCostSkate = 500;
        RealUpgradeLevelSkate = 1;
        RealUpgradeCostSepatu = 500;
        RealUpgradeLevelSepatu = 1;

        //Pemanggilan Fungsi
        SaveData();
        LoadData();
    }
    #endregion

    //Save dan Load Data
    #region REGION SAVE DAN LOAD
    public void SaveData()
    {
        GetdataUI();
        SaveSystem_Mainmenu.SavePlayer(this);
    }
    public void SaveDataMM()
    {
        GetdataUIWithoutResult();
        SaveSystem_Mainmenu.SavePlayer(this);
    }
    public void LoadData()
    {
        MainMenuData data = SaveSystem_Mainmenu.LoadPlayer();
        //Welcome Panel
        WelcomePanelActive = data.WelcomePanelActive;

        //Main menu
        RealCoin = data.RealCoin;
        RealMagnet = data.RealMagnet;
        RealSepatu = data.RealSepatu;

        //Misi
        Misi_1_Complete = data.Misi_1_Complete;
        Misi_2_Complete = data.Misi_2_Complete;
        Misi_3_Complete = data.Misi_3_Complete;
        Misi_4_Complete = data.Misi_4_Complete;

        // Achievement
        Achievement_1_Complete = data.Achievement_1_Complete;
        Achievement_2_Complete = data.Achievement_2_Complete;
        Achievement_3_Complete = data.Achievement_3_Complete;

        //MeCharacter
        R_MeCharacter1_Status = data.R_MeCharacter1_Status;
        R_MeCharacter2_Status = data.R_MeCharacter2_Status;
        R_MeCharacterYangDipilih_Nama = data.R_MeCharacterYangDipilih_Nama;
        R_MeCharacterYangDipilih_TextStatus = data.R_MeCharacterYangDipilih_TextStatus;
        R_MeCharacterYangDipilih_Status = data.R_MeCharacterYangDipilih_Status;


        //CharacterShop
        R_Character1_Status = data.R_Character1_Status;
        R_Character2_Status = data.R_Character2_Status;

        R_CharacterYangDipilih_Nama = data.R_CharacterYangDipilih_Nama;
        R_CharacterYangDipilih_Harga = data.R_CharacterYangDipilih_Harga;
        R_CharacterYangDipilih_Status = data.R_CharacterYangDipilih_Status;

        //ItemShop
        R_Magnet_Jumlah = data.R_Magnet_Jumlah;
        R_Sepatu_Jumlah = data.R_Sepatu_Jumlah;

        R_Magnet_Status = data.R_Magnet_Status;
        R_Sepatu_Status = data.R_Sepatu_Status;

        R_ItemYangDipilih_Nama = data.R_ItemYangDipilih_Nama;
        R_ItemYangDipilih_Harga = data.R_ItemYangDipilih_Harga;
        R_ItemYangDipilih_Jumlah = data.R_ItemYangDipilih_Jumlah;


        //Upgrade
        RealUpgradeCostSkate = data.RealUpgradeCostSkate;
        RealUpgradeLevelSkate = data.RealUpgradeLevelSkate;
        RealUpgradeCostSepatu = data.RealUpgradeCostSepatu;
        RealUpgradeLevelSepatu = data.RealUpgradeLevelSepatu;
        SetdataUI();

    }

    #endregion

    //REGION
    #region REGION LOAD DATA LEVEL
    public void LoadDataLevel()
    {
        LoadDataLevel_1();
        LoadDataLevel_2();
        LoadDataLevel_3();
        LoadDataLevel_4();
        LoadDataLevel_5();
    }
    public void LoadDataLevel_1()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        int Bintang = datalevel.Health_1;
        if (Bintang == 3)
        {
            BintangKiri_lvl_1.SetActive(true);
            BintangTengah_lvl_1.SetActive(true);
            Bintangkanan_lvl_1.SetActive(true);
        }
        else if (Bintang == 2)
        {
            BintangKiri_lvl_1.SetActive(true);
            Bintangkanan_lvl_1.SetActive(true);
        }
        else if (Bintang == 1)
        {
            BintangKiri_lvl_1.SetActive(true);
        }
        TotalScore_Lvl_1.text = datalevel.Totalscore_1.ToString();
    }
    public void LoadDataLevel_2()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        int Bintang = datalevel.Health_2;
        if (Bintang == 3)
        {
            BintangKiri_lvl_2.SetActive(true);
            BintangTengah_lvl_2.SetActive(true);
            Bintangkanan_lvl_2.SetActive(true);
        }
        else if (Bintang == 2)
        {
            BintangKiri_lvl_2.SetActive(true);
            Bintangkanan_lvl_2.SetActive(true);
        }
        else if (Bintang == 1)
        {
            BintangKiri_lvl_2.SetActive(true);
        }
        TotalScore_Lvl_2.text = datalevel.Totalscore_2.ToString();
    }
    public void LoadDataLevel_3()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        int Bintang = datalevel.Health_3;
        if (Bintang == 3)
        {
            BintangKiri_lvl_3.SetActive(true);
            BintangTengah_lvl_3.SetActive(true);
            Bintangkanan_lvl_3.SetActive(true);
        }
        else if (Bintang == 2)
        {
            BintangKiri_lvl_3.SetActive(true);
            Bintangkanan_lvl_3.SetActive(true);
        }
        else if (Bintang == 1)
        {
            BintangKiri_lvl_3.SetActive(true);
        }
        TotalScore_Lvl_3.text = datalevel.Totalscore_3.ToString();
    }
    public void LoadDataLevel_4()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        int Bintang = datalevel.Health_4;
        if (Bintang == 3)
        {
            BintangKiri_lvl_4.SetActive(true);
            BintangTengah_lvl_4.SetActive(true);
            Bintangkanan_lvl_4.SetActive(true);
        }
        else if (Bintang == 2)
        {
            BintangKiri_lvl_4.SetActive(true);
            Bintangkanan_lvl_4.SetActive(true);
        }
        else if (Bintang == 1)
        {
            BintangKiri_lvl_4.SetActive(true);
        }
        TotalScore_Lvl_4.text = datalevel.Totalscore_4.ToString();
    }
    public void LoadDataLevel_5()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        int Bintang = datalevel.Health_5;
        if (Bintang == 3)
        {
            BintangKiri_lvl_5.SetActive(true);
            BintangTengah_lvl_5.SetActive(true);
            Bintangkanan_lvl_5.SetActive(true);
        }
        else if (Bintang == 2)
        {
            BintangKiri_lvl_5.SetActive(true);
            Bintangkanan_lvl_5.SetActive(true);
        }
        else if (Bintang == 1)
        {
            BintangKiri_lvl_5.SetActive(true);
        }
        TotalScore_Lvl_5.text = datalevel.Totalscore_5.ToString();
    }

    #endregion

    #region REGION UNLOCK LEVEL
    //Unlock level 2
    protected void CheckLevelStatus()
    {
        CheckLevel2Status();
        CheckLevel3Status();
        CheckLevel4Status();
        CheckLevel5Status();
    }
    protected void CheckLevel2Status()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        int Bintang = datalevel.Health_1;
        if (Bintang >= 1)
        {
            Level_2_Lock.SetActive(false);
            Level_2_Unlock.SetActive(true);
        }
    }

    //Unlock level 3
    protected void CheckLevel3Status()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        int Bintang = datalevel.Health_2;
        if (Bintang >= 1)
        {
            Level_3_Lock.SetActive(false);
            Level_3_Unlock.SetActive(true);
        }
    }

    //Unlock level 4
    protected void CheckLevel4Status()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        int Bintang = datalevel.Health_3;
        if (Bintang >= 1)
        {
            Level_4_Lock.SetActive(false);
            Level_4_Unlock.SetActive(true);
        }
    }

    //Unlock level 6
    protected void CheckLevel5Status()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        int Bintang = datalevel.Health_4;
        if (Bintang >= 1)
        {
            Level_5_Lock.SetActive(false);
            Level_5_Unlock.SetActive(true);
        }
    }
    #endregion

    #region REGION FUNCTION WELCOME PANEL
    public void CheckStatusWelcomePanel()
    {
        if (WelcomePanelActive == true)//jika ini terjadi berarti pemain belum pernah masuk sebelumnya atau pemain baru
        {
            WelcomePanel.SetActive(true);
        } else if (WelcomePanelActive == false)
        {
            WelcomePanel.SetActive(false);
        }
    }
    public void GetCoinFromWelcomePanel()
    {
        if (WelcomePanelActive == true)
        {
            SetDefault();
            WelcomePanelActive = false;
            SaveData();
            WelcomePanel.SetActive(false);
        }
        LoadData();
    }
    #endregion

    #region REGION FUNCTION LEADERGBOARD 
    public void CheckLeaderBoard()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        R_TotalScore_Player = datalevel.Totalscore_1 + datalevel.Totalscore_2 + datalevel.Totalscore_3 + datalevel.Totalscore_4 + datalevel.Totalscore_5;
        Debug.Log("Total score = " + R_TotalScore_Player);

        if(R_TotalScore_Player > R_TotalScore_KangTechno)
        {
            //Player jadi pertama
            Name_Rank1.text = R_Name_Player;
            TotalScore_Rank1.text = R_TotalScore_Player.ToString();

            //kang Techno jadi kedua
            Name_Rank2.text = R_Name_KangTechno;
            TotalScore_Rank2.text = R_TotalScore_KangTechno.ToString();

            //Neng Techno jadi Ketiga
            Name_Rank3.text = R_Name_NengTechno;
            TotalScore_Rank3.text = R_TotalScore_NengTechno.ToString();
        }
        else if(R_TotalScore_Player > R_TotalScore_NengTechno && R_TotalScore_Player < R_TotalScore_KangTechno)
        {
            //Kang Techno Tetap Pertama
            Name_Rank1.text = R_Name_KangTechno;
            TotalScore_Rank1.text = R_TotalScore_KangTechno.ToString();

            //Player Jadi kedua
            Name_Rank2.text = R_Name_Player;
            TotalScore_Rank2.text = R_TotalScore_Player.ToString();

            //Neng Techno Jadi ketiga
            Name_Rank3.text = R_Name_NengTechno;
            TotalScore_Rank3.text = R_TotalScore_NengTechno.ToString();
        }
        else if(R_TotalScore_Player < R_TotalScore_NengTechno && R_TotalScore_Player < R_TotalScore_KangTechno)
        {
            //tampilan semula
            Name_Rank1.text = R_Name_KangTechno;
            TotalScore_Rank1.text = R_TotalScore_KangTechno.ToString();

            Name_Rank2.text = R_Name_NengTechno;
            TotalScore_Rank2.text = R_TotalScore_NengTechno.ToString();

            Name_Rank3.text = R_Name_Player;
            TotalScore_Rank3.text = R_TotalScore_Player.ToString();
        }

    }
    #endregion

    #region REGION FUNCTION MISION
    public void CheckStatusMision()
    {
        CheckStatusMision1();
        CheckStatusMision2();
        CheckStatusMision3();
        CheckStatusMision4();
    }
    public void CheckStatusMision1()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        if (datalevel.Health_1 == 3 && Misi_1_Complete == false)
        {
            Misi_1_Checklist.SetActive(true);
            Misi_1_Complete = true;
            SaveData();
            LoadData();
        }
        else if(Misi_1_Complete == true)
        {
            Misi_1_Checklist.SetActive(true);
        }
    }
    public void CheckStatusMision2()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        if (datalevel.Health_3 == 3 && Misi_2_Complete == false)
        {
            Misi_2_Checklist.SetActive(true);
            Misi_2_Complete = true;
            SaveData();
            LoadData();
        }
        else if(Misi_2_Complete == true)
        {
            Misi_2_Checklist.SetActive(true);
        }
    }
    public void CheckStatusMision3()
    {
        if (RealCoinResult == 7000 && Misi_3_Complete == false)
        {
            Misi_3_Checklist.SetActive(true);
            Misi_3_Complete = true;
            SaveData();
            LoadData();
        }
        else if(Misi_3_Complete == true)
        {
            Misi_3_Checklist.SetActive(true);
        }
    }
    public void CheckStatusMision4()
    {
        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        if (datalevel.Health_5 == 3 && Misi_4_Complete == false)
        {
            Misi_4_Checklist.SetActive(true);
            Misi_4_Complete = true;
            SaveData();
            LoadData();
        }
        else if (Misi_4_Complete == true)
        {
            Misi_4_Checklist.SetActive(true);
        }
    }
    #endregion

    #region REGION FUNCTION Achievement

    public void CheckStatusAchievement()
    {
        CheckStatusAchievement1();
        CheckStatusAchievement2();
        CheckStatusAchievement3();
    }
    public void CheckStatusAchievement1()
    {
        if (RealCoinResult == 7000 && Achievement_1_Complete == false)
        {
            Achievement_1_fullBar.SetActive(true);
            Achievement_1_Complete = true;
            SaveData();
            LoadData();
        }
        else if (Achievement_1_Complete == true)
        {
            Achievement_1_fullBar.SetActive(true);
        }
    }
    public void CheckStatusAchievement2()
    {

        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        if (datalevel.Health_1 >= 1 && 
            datalevel.Health_2 >= 1 && 
            datalevel.Health_3 >= 1 && 
            datalevel.Health_4 >= 1 && 
            datalevel.Health_5 >= 1 && 
            Achievement_2_Complete == false)
        {
            Achievement_2_fullBar.SetActive(true);
            Achievement_2_Complete = true;
            SaveData();
            LoadData();
        }
        else if (Achievement_2_Complete == true)
        {
            Achievement_2_fullBar.SetActive(true);
        }
    }
    public void CheckStatusAchievement3()
    {

        ResultData datalevel = SaveSystem_Result.LoadPlayer();
        if (datalevel.Health_1 == 3 &&
            datalevel.Health_2 == 3 &&
            datalevel.Health_3 == 3 &&
            datalevel.Health_4 == 3 &&
            datalevel.Health_5 == 3 &&
            Achievement_3_Complete == false)
        {
            Achievement_3_fullBar.SetActive(true);
            Achievement_3_Complete = true;
            SaveData();
            LoadData();
        }
        else if (Achievement_3_Complete == true)
        {
            Achievement_3_fullBar.SetActive(true);
        }
    }
    #endregion

    #region REGION FUNCTION ITEM LOCK
    public void ItemLock()
    {
        ItemLockMeCh1();
        ItemLockMeCh2();
        ItemLockCh1();
        ItemLockCh2();
    }
    #endregion

    #region REGION FUNCTION ME CHARACTER
    public void ItemLockMeCh1()
    {
        if (R_Character1_Status == false)
        {
            MeCharacter1_terkunci.SetActive(true);
        }
        else
        {
            MeCharacter1_terkunci.SetActive(false);
        }

    }
    public void ItemLockMeCh2()
    {
        if (R_Character2_Status == false)
        {
            MeCharacter2_terkunci.SetActive(true);
        }
        else
        {
            MeCharacter2_terkunci.SetActive(false);
        }

    }


    //Pilih Item Character yang ada di MeCharacter
    public void PilihMeCharacterA()
    {
        if(Character1_Status == true)
        {
            MeCharacterYangDipilih_Terkunci.SetActive(false);
            if (R_MeCharacter1_Status == false)
            {
                R_MeCharacterYangDipilih_Nama = "Kang Techno";
                R_MeCharacterYangDipilih_TextStatus = "Tidak";
                R_MeCharacterYangDipilih_Status = R_MeCharacter1_Status;
                Debug.Log("PilihMeCharacterA kondisi false" + R_MeCharacterYangDipilih_Status);
                SaveDataMM();
            }
            else
            {
                R_MeCharacterYangDipilih_Nama = "Kang Techno";
                R_MeCharacterYangDipilih_TextStatus = "Dipakai";
                R_MeCharacterYangDipilih_Status = R_MeCharacter1_Status;

                Debug.Log("PilihMeCharacterA kondisi true" + R_MeCharacterYangDipilih_Status);
                SaveDataMM();
            }
            
        }
        else
        {

            MeCharacterYangDipilih_Terkunci.SetActive(true);
            R_MeCharacterYangDipilih_Nama = "Kang Techno";
            R_MeCharacterYangDipilih_TextStatus = "Belum Beli";
            R_MeCharacterYangDipilih_Status = R_MeCharacter1_Status;
            Debug.Log("Karakter ini belum Dibeli");
            SaveDataMM();
        }
        LoadData();
    }
    public void PilihMeCharacterB()
    {
        if(Character2_Status == true) {
            MeCharacterYangDipilih_Terkunci.SetActive(false);
            if (R_MeCharacter2_Status == false)
            {
                R_MeCharacterYangDipilih_Nama = "Neng Techno";
                R_MeCharacterYangDipilih_TextStatus = "Tidak";
                R_MeCharacterYangDipilih_Status = R_MeCharacter2_Status;

                Debug.Log("PilihMeCharacterB kondisi false" + R_MeCharacterYangDipilih_Status);
                SaveDataMM();
            }
            else
            {
                R_MeCharacterYangDipilih_Nama = "Neng Techno";
                R_MeCharacterYangDipilih_TextStatus = "Dipakai";
                R_MeCharacterYangDipilih_Status = R_MeCharacter2_Status;

                Debug.Log("PilihMeCharacterB kondisi true" + R_MeCharacterYangDipilih_Status);
                SaveDataMM();
            }
        }
        else
            {
                MeCharacterYangDipilih_Terkunci.SetActive(true);
                R_MeCharacterYangDipilih_Nama = "Neng Techno";
                R_MeCharacterYangDipilih_TextStatus = "Belum Beli";
                R_MeCharacterYangDipilih_Status = R_MeCharacter2_Status;
                Debug.Log("Karakter ini belum anda beli");
            SaveDataMM();
            }

        LoadData();
    }

    public void GunakanCharacter()
    {
       if(R_MeCharacterYangDipilih_Nama == "Kang Techno")
        {
            if(Character1_Status == true)//Jika karakternya sudah dibeli maka lakukkan perintah dibawah
            {

                R_MeCharacterYangDipilih_Nama = "Kang Techno";
                R_MeCharacterYangDipilih_TextStatus = "Dipakai";
                R_MeCharacter1_Status = true;
                R_MeCharacter2_Status = false;
                Debug.Log("Karakter ini Dipakai");
                //untuk di set ke karakter


                SaveDataMM();
                LoadData();
            }
            else
            {
                R_MeCharacterYangDipilih_Nama = "Kang Techno";
                R_MeCharacterYangDipilih_TextStatus = "Belum beli";
                R_MeCharacter1_Status = false;
                R_MeCharacter2_Status = true;
                Debug.Log("Karakter ini Belum dibeli");
                //untuk di set ke karakter


                SaveDataMM();
                LoadData();
            }
        }
        if(R_MeCharacterYangDipilih_Nama == "Neng Techno")
        {
            if (Character1_Status == true)//Jika karakternya sudah dibeli maka lakukkan perintah dibawah
            {
                R_MeCharacterYangDipilih_Nama = "Neng Techno";
                R_MeCharacterYangDipilih_TextStatus = "Dipakai";
                R_MeCharacter2_Status = true;
                R_MeCharacter1_Status = false;
                Debug.Log("Karakter ini Dipakai");
                //untuk di set ke karakter


                SaveDataMM();
                LoadData();
            }
            else
            {
                R_MeCharacterYangDipilih_Nama = "Neng Techno";
                R_MeCharacterYangDipilih_TextStatus = "Belum beli";
                R_MeCharacter2_Status = false;
                R_MeCharacter1_Status = true;
                //untuk di set ke karakter


                SaveDataMM();
                LoadData();
            }
        }
    }
    #endregion

    #region REGION FUNCTION ITEMSHOP
    public void ValueInShop()
    {
        TextCoinShop.text = TextCoin.text;
        TextMagnetShop.text = TextMagnet.text;
        TextSepatuShop.text = TextSepatu.text;
    }
    
    public void CheckUpdatedataItemShop()
    {
        if (R_ItemYangDipilih_Nama == R_Magnet_Nama)
        {
            R_ItemYangDipilih_Jumlah = RealMagnet;
            SaveDataMM();

            LoadData();
        }
        else if (R_ItemYangDipilih_Nama == R_Sepatu_Nama)
        {
            R_ItemYangDipilih_Jumlah = R_Sepatu_Jumlah;
            SaveDataMM();

            LoadData();
        }
    }
    //Pilih Item yang ada di iTEMShop
    public void PilihItemMagnet()
    {
      
        R_ItemYangDipilih_Nama = R_Magnet_Nama;
        R_ItemYangDipilih_Harga = R_Magnet_Harga;
        R_ItemYangDipilih_Jumlah = R_Magnet_Jumlah;
        R_Magnet_Status = true;
        R_Sepatu_Status = false;
        SaveDataMM();

        LoadData();
        checkPanelBeliItem();


    }  
    public void PilihItemSepatu()
    {
        R_ItemYangDipilih_Nama = R_Sepatu_Nama;
        R_ItemYangDipilih_Harga = R_Sepatu_Harga;
        R_ItemYangDipilih_Jumlah = R_Sepatu_Jumlah;

        R_Sepatu_Status = true;
        R_Magnet_Status = false;
        SaveDataMM();

        LoadData();
        checkPanelBeliItem();
    }

    public void checkPanelBeliItem()
    {
        if(R_Magnet_Status == true)
        {
            ItemYangDipilih_Magnet_Gambar.SetActive(true);
            ItemYangDipilih_Sepatu_Gambar.SetActive(false);
        }
        else
        {
            ItemYangDipilih_Magnet_Gambar.SetActive(false);
            ItemYangDipilih_Sepatu_Gambar.SetActive(true);

        }
    }

    //Beli Item Booster yang sebelumnya sudah dipilih
    public void BeliItemBooster()
    {
        if (RealCoin > R_ItemYangDipilih_Harga || RealCoin == R_ItemYangDipilih_Harga )
        {
            if(R_ItemYangDipilih_Nama == R_Magnet_Nama)
            {
                RealCoin = RealCoin - R_ItemYangDipilih_Harga;
                RealMagnet = RealMagnet + 1;
                R_Magnet_Jumlah = R_Magnet_Jumlah + 1;
                R_ItemYangDipilih_Jumlah = R_Magnet_Jumlah;
                SaveDataMM();

                //Debug.Log("Pembelian berhasil !!");
                //Debug.Log("Coin Sekarang jadi  = " + RealCoin);
            }
            else if(R_ItemYangDipilih_Nama == R_Sepatu_Nama)
            {
                RealCoin = RealCoin - R_ItemYangDipilih_Harga;
                RealSepatu = RealSepatu + 1;
                R_Sepatu_Jumlah = R_Sepatu_Jumlah + 1;
                R_ItemYangDipilih_Jumlah = R_Sepatu_Jumlah;
                SaveDataMM();

                //Debug.Log("Pembelian berhasil !!");
                //Debug.Log("Coin Sekarang jadi  = " + RealCoin);

            }

        }
        else if (RealCoin < R_ItemYangDipilih_Harga)
        {
            Debug.Log("Coin Tidak mencukupi");

        }
        LoadData();
        ValueInShop();
    }
    #endregion

    #region REGION FUNCTION CHARACTERSHOP
    //Pengkondisian Item Character yang ada di CharacterShop
    public void ItemLockCh1()
    {
        //Pengkondisian untuk item Character 1/A Jika Player "BELUM" beli item ini maka icon/gambar kunci akan muncul dan sebaliknya.
        if (R_Character1_Status == false)
        {
            Character1_terkunci.SetActive(true);
        }
        else
        {
            Character1_terkunci.SetActive(false);
        }

    }
    public void ItemLockCh2()
    {
        //Pengkondisian untuk item Character 2/B Jika Player "BELUM" beli item ini maka icon/gambar kunci akan muncul dan sebaliknya.
        if (R_Character2_Status == false)
        {
            Character2_terkunci.SetActive(true);
        }
        else
        {
            Character2_terkunci.SetActive(false);
        }

    }


    //Pilih Item Character yang ada di CharacterShop
    public void PilihCharacterA()
    {
        //Jika Player menekan Character 1/A dan statusnya false, maka data nama dan harga akan di set ke panel atas. Tapi jika true data harga akan di set 0 tanda item sudah dibeli.
        if (R_Character1_Status == false)
        {
            R_CharacterYangDipilih_Nama = R_Character1_Nama;
            R_CharacterYangDipilih_Harga = R_Character1_Harga;
            R_CharacterYangDipilih_Status = R_Character1_Status;
            SaveDataMM();
        }
        else
        {
            R_CharacterYangDipilih_Nama = R_Character1_Nama;
            R_CharacterYangDipilih_Harga = 0;
            R_CharacterYangDipilih_Status = R_Character1_Status;
            SaveDataMM();
        }
        LoadData();
    }
    public void PilihCharacterB()
    {
        //Jika Player menekan Skate 2/B dan statusnya false, maka data nama dan harga akan di set ke panel atas. Tapi jika true data harga akan di set 0 tanda item sudah dibeli. 
        if (R_Character2_Status == false)
        {
            R_CharacterYangDipilih_Nama = R_Character2_Nama;
            R_CharacterYangDipilih_Harga = R_Character2_Harga;
            R_CharacterYangDipilih_Status = R_Character2_Status;
            SaveDataMM();
        }
        else
        {
            R_CharacterYangDipilih_Nama = R_Character2_Nama;
            R_CharacterYangDipilih_Harga = 0;
            R_CharacterYangDipilih_Status = R_Character2_Status;
            SaveDataMM();
        }
        LoadData();
    }


    //Beli Item Character yang ada di Charactershop
    public void BeliItemCharacter()
    {
        if (RealCoin > R_CharacterYangDipilih_Harga && R_CharacterYangDipilih_Status == false || RealCoin == R_CharacterYangDipilih_Harga && R_CharacterYangDipilih_Status == false)
        {
            if (R_CharacterYangDipilih_Nama == R_Character1_Nama)
            {
                RealCoin = RealCoin - R_CharacterYangDipilih_Harga;
                Debug.Log("Pembelian berhasil !!");
                Debug.Log("Coin Sekarang jadi  = " + RealCoin);
                R_Character1_Status = true;
                SaveDataMM();
                ItemLockMeCh1();
                ItemLockCh1();
                R_CharacterYangDipilih_Harga = 0;
                
            }
            if (R_CharacterYangDipilih_Nama == R_Character2_Nama)
            {
                RealCoin = RealCoin - R_CharacterYangDipilih_Harga;
                Debug.Log("Pembelian berhasil !!");
                Debug.Log("Coin Sekarang jadi  = " + RealCoin);
                R_Character2_Status = true;
                SaveDataMM();
                ItemLockCh2();
                ItemLockMeCh2();
                R_CharacterYangDipilih_Harga = 0;
                
            }

        }
        if (R_CharacterYangDipilih_Status == true)
        {
            Debug.Log("Item sudah dibeli");

        }
        if (RealCoin < R_CharacterYangDipilih_Harga)
        {
            Debug.Log("Coin Tidak mencukupi");

        }
        LoadData();
        ValueInShop();
    }
    #endregion

    #region REGION FUNCTION UPGRADESHOP
    //Upgrade Sepatu yang ada di panel Upgrade
    public void UpgradeSepatu()
    {
        if (RealCoin > RealUpgradeCostSepatu || RealCoin == RealUpgradeCostSepatu)
        {
            RealCoin = RealCoin - RealUpgradeCostSepatu;
            Debug.Log("Sepatu berhasil di Tingkatkan !!");
            Debug.Log("Coin Sekarang jadi  = " + RealCoin);
            RealUpgradeCostSepatu = RealUpgradeCostSepatu * 2;
            Debug.Log("Harga Sepatu Sekarang jadi  = " + RealUpgradeCostSepatu);
            RealUpgradeLevelSepatu = RealUpgradeLevelSepatu + 1;
            Debug.Log("Level Sepatu Sekarang jadi  = " + RealUpgradeLevelSepatu);
            SaveData();
        }
        if (RealCoin < RealUpgradeCostSepatu)
        {
            Debug.Log("Coin anda tidak mencukupi untuk upgrade?");
        }
        LoadData();
        ValueInShop();
    }

    //Upgrade Skate yang ada di panel Upgrade
    public void UpgradeSkate()
    {
        if (RealCoin > RealUpgradeCostSkate || RealCoin == RealUpgradeCostSkate)
        {
            RealCoin = RealCoin - RealUpgradeCostSkate;
            Debug.Log("Skate berhasil di Tingkatkan !!");
            Debug.Log("Coin Sekarang jadi  = " + RealCoin);
            RealUpgradeCostSkate = RealUpgradeCostSkate * 2;
            Debug.Log("Harga Skate sekarang menjadi = " + RealUpgradeCostSkate);
            RealUpgradeLevelSkate = RealUpgradeLevelSkate + 1;
            Debug.Log("Level Skate sekarang menjadi = " + RealUpgradeLevelSkate);
            SaveData();
        }
        if (RealCoin < RealUpgradeCostSkate)
        {
            Debug.Log("Coin anda tidak mencukupi untuk upgrade");
        }
        LoadData();
        ValueInShop();
    }

    #endregion



}

