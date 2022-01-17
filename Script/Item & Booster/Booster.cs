using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Booster : MonoBehaviour
{

    private float Magnetcd = 5f;
    private float Shoecd = 3f;

    public int jumlahItemShoe = 2;
    public int jumlahItemMagnet = 2;

    public int R_Magnet_Jumlah;
    public int R_Sepatu_Jumlah;

    public Text CdTextShoe;
    public Text CdTextMagnet;

    public Text jumlahShoeText;
    public Text jumlahMagnetText;

    public GameObject PanelpenutupMagnet;
    public GameObject PanelpenutupShoe;

    public GameObject PanelcdShoe;
    public GameObject PanelcdMagnet;

    public GameObject coinDetector;


    public static bool setActiveCDMagnet;

    public static bool setActiveCDShoe ;

    void Start()
    {
        CheckItemBooster();
        setActiveCDMagnet = false;
        setActiveCDShoe = false;

        jumlahShoeText.text = jumlahItemShoe.ToString();
        jumlahMagnetText.text = jumlahItemMagnet.ToString();

        coinDetector = GameObject.FindGameObjectWithTag("CoinDetector");
        coinDetector.SetActive(false);

    }

    void Update()
    {
        
        setActiveShoe();
        setActiveMagnet();
        if (jumlahItemShoe == 0)
        {
            PanelpenutupShoe.SetActive(true);
        }
        if (jumlahItemMagnet == 0)
        {
            PanelpenutupMagnet.SetActive(true);
        }
        R_Magnet_Jumlah = jumlahItemMagnet;
        R_Sepatu_Jumlah = jumlahItemShoe;
        SaveSystem_Booster.SavePlayer(this);

        
    }

    public void CheckItemBooster()
    {
        MainMenuData Data = SaveSystem_Mainmenu.LoadPlayer();
        jumlahItemMagnet = Data.R_Magnet_Jumlah;
        Debug.Log("Jumlah Magnet = " + jumlahItemMagnet);
        jumlahItemShoe = Data.R_Sepatu_Jumlah;
        Debug.Log("Jumlah Sepatu = " + jumlahItemShoe);
    }
    public void setActiveShoe()
    {
        if (setActiveCDShoe && Shoecd >= 0)
        {
            Shoecd -= Time.deltaTime;
            CdTextShoe.text = ((int)Shoecd).ToString();
        }
        else if (Shoecd <= 0)
        {
            setActiveCDShoe = !setActiveCDShoe;
            PanelpenutupShoe.SetActive(false);
            PanelcdShoe.SetActive(false);
            Player_2Jalur.JumpPower = 8;
            Shoecd = 3;
        }
    }

    public void setActiveMagnet()
    {
        if (setActiveCDMagnet && Magnetcd >= 0)
        {
            Magnetcd -= Time.deltaTime;
            CdTextMagnet.text = ((int)Magnetcd).ToString();

        }
        else if (Magnetcd <= 0)
        {
            setActiveCDMagnet = !setActiveCDMagnet;
            PanelpenutupMagnet.SetActive(false);
            PanelcdMagnet.SetActive(false);
            coinDetector.SetActive(false);


            Magnetcd = 3;
        }
    }

    public void ButtonMagnet()
    {

        if(jumlahItemMagnet > 0)
        {
            if (Magnetcd >= 0)
            {
                PanelpenutupMagnet.SetActive(true);
            }
            PanelcdMagnet.SetActive(true);
            setActiveCDMagnet = true;

            jumlahItemMagnet = jumlahItemMagnet -1;

            

            jumlahMagnetText.text = jumlahItemMagnet.ToString();

            //Magnet
            coinDetector.SetActive(true);
        }

    }

    public void ButtonShoe()
    {


        if(jumlahItemShoe > 0)
        {
            if (Shoecd >= 0)
            {
                PanelpenutupShoe.SetActive(true);
            }
            PanelcdShoe.SetActive(true);
            setActiveCDShoe = true;
            Player_2Jalur.JumpPower = 15;

            jumlahItemShoe = jumlahItemShoe - 1;



            jumlahShoeText.text = jumlahItemShoe.ToString();
        }
    }








}
