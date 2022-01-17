using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BoosterData 
{
    public int R_Magnet_Jumlah;
    public int R_Sepatu_Jumlah;

    public BoosterData (Booster booster)
    {
    R_Magnet_Jumlah = booster.R_Magnet_Jumlah;
    R_Sepatu_Jumlah = booster.R_Sepatu_Jumlah;
}
}
